using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using SSHTunnelManager.Business;
using SSHTunnelManager.Properties;
using SSHTunnelManager.Util;

namespace SSHTunnelManager.Domain
{
    public class EncryptedStorage
    {
        private static readonly byte[] _passwordCheckString = Encoding.ASCII.GetBytes(@"MAGIC");
        private static readonly XmlSerializer _serializer = new XmlSerializer(typeof(EncryptedStorageContent));

        /// <summary>
        /// Load storage from file.
        /// </summary>
        /// <param name="filename">Full filepath for encrypted storage file.</param>
        /// <param name="password">Master password for encrypted storage file.</param>
        public EncryptedStorage(string filename, string password)
        {
            if (filename == null) throw new ArgumentNullException("filename");
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password))
                throw new EncryptedStorageException(Resources.EncryptedStorage_EmptyPasswordProvided);

            using (var inputXml = new MemoryStream())
            {
                // get decrypted stream
                try
                {
                    using (var file = File.OpenRead(filename))
                        CryptoHelper.DecryptAes(file, inputXml, password);
                }
                catch (CryptographicException e)
                {
                    if (e.Message == @"Padding is invalid and cannot be removed.") 
                        // In most cases this means what password is invalid, but also can mean what storage is broken.
                        throw new EncryptedStorageException(Resources.EncryptedStorage_InvalidPassword);
                    throw;
                }
                inputXml.Seek(0, SeekOrigin.Begin);
                var buffer = new byte[_passwordCheckString.Length];
                var readed = inputXml.Read(buffer, 0, buffer.Length);
                if (readed != buffer.Length || !_passwordCheckString.SequenceEqual(buffer))
                {
                    throw new EncryptedStorageException(Resources.EncryptedStorage_InvalidPassword);
                }
                // read content
                Data = readData(inputXml);
            }
        }

        /// <summary>
        /// Create encrypted storage.
        /// </summary>
        public EncryptedStorage()
        {
            Data = new EncryptedStorageContent();
        }

        public EncryptedStorageContent Data { get; private set; }

        /// <summary>
        /// Save storage to file.
        /// </summary>
        /// <param name="filename">Full filepath for encrypted storage file.</param>
        /// <param name="password">Master password for encrypted storage file.</param>
        public void Save(string filename, string password)
        {
            var stream = new MemoryStream();
            stream.Write(_passwordCheckString, 0, _passwordCheckString.Length);
            XmlWriter writer = XmlWriter.Create(stream, new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = true });
            _serializer.Serialize(writer, Data);
            writer.Flush();
            writer.Close();

            using (var encryptedXmlStream = File.Open(filename, FileMode.Create, FileAccess.Write))
            {
                stream.Seek(0, SeekOrigin.Begin);
                CryptoHelper.EncryptAes(stream, encryptedXmlStream, password);
            }
        }

        private static EncryptedStorageContent readData(Stream xmlStream)
        {
            var data = (EncryptedStorageContent)_serializer.Deserialize(xmlStream);

            var hostsByName = data.Hosts.ToDictionary(h => h.Name);
            // Установка связанных зависимостей
            foreach (var host in data.Hosts.Where(h => !string.IsNullOrWhiteSpace(h.DependsOnStr)))
            {
                var depStr = host.DependsOnStr;
                if (!hostsByName.ContainsKey(depStr))
                {
                    throw new Exception(string.Format(Resources.EncryptedStorage_RequiredHostNotFound, host.Name, depStr));
                }
                host.DependsOn = hostsByName[depStr];
            }

            data.Hosts = DevExpress.Utils.Algorithms.TopologicalSort(data.Hosts, new HostInfoComparer()).Reverse().ToList();
            return data;
        }
    }
}
