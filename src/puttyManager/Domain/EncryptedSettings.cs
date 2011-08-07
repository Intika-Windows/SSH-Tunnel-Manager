using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using PuttyManager.Business;
using PuttyManager.Util;

namespace PuttyManager.Domain
{
    [Serializable]
    [XmlRoot("Settings")]
    public class EncryptedStorageContent
    {
        public EncryptedStorageContent()
        {
            Hosts = new List<HostInfo>();
        }

        // Topological sorted hosts information. Less index => less dependencies.
        public List<HostInfo> Hosts { get; set; }
    }

    public class EncryptedStorageException : Exception
    {
        public EncryptedStorageException() { }
        public EncryptedStorageException(string message) : base(message) { }
        public EncryptedStorageException(string message, Exception innerException) : base(message, innerException) { }
        protected EncryptedStorageException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }

    public class EncryptedStorage
    {
        private static readonly byte[] _passwordCheckString = Encoding.ASCII.GetBytes("MAGIC");
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
                throw new EncryptedStorageException("Empty password provided.");

            using (var inputXml = new MemoryStream())
            {
                // get decrypted stream
                using (var file = File.OpenRead(filename))
                    CryptoHelper.DecryptAes(file, inputXml, password);
                inputXml.Seek(0, SeekOrigin.Begin);
                var buffer = new byte[_passwordCheckString.Length];
                var readed = inputXml.Read(buffer, 0, buffer.Length);
                if (readed != buffer.Length || _passwordCheckString.SequenceEqual(buffer))
                {
                    throw new EncryptedStorageException("Invalid password.");
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
                    throw new Exception(string.Format("Требуемый для работы хоста '{0}' хост '{1}' не найден.", host.Name, depStr));
                }
                host.DependsOn = hostsByName[depStr];
            }

            data.Hosts = DevExpress.Utils.Algorithms.TopologicalSort(data.Hosts, new HostInfoComparer()).Reverse().ToList();
            return data;
        }
    }

    /*public class EncryptedSettings
    {
        private const string ExplicitXmlSettingsFile = @"\settings.xml";
        private const string EncryptedXmlSettingsFile = @"\settings.encrypted";

        private static readonly XmlSerializer _serializer = new XmlSerializer(typeof(EncryptedSettings));

        #region Singleton

        private static EncryptedSettings _instance;

        protected EncryptedSettings()
        {
            Hosts = new List<HostInfo>();
        }

        public static EncryptedSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    loadInstance();
                }
                return _instance;
            }
        }

        #endregion

        #region Static members

        [XmlIgnore]
        private static string Password { get; set; }
        
        /// <summary>
        /// Источник данных: xml-файл или зашифрованный AES xml-файл.
        /// </summary>
        public static ESettingsSource SettingsSource
        {
            get
            {
                var appPath = Application.StartupPath;
                if (File.Exists(appPath + ExplicitXmlSettingsFile))
                {
                    return ESettingsSource.ExplicitXml;
                }
                if (EncryptedSourceExist)
                {
                    return ESettingsSource.EncryptedXml;
                }
                return ESettingsSource.Invalid;
            }
        }

        public static bool EncryptedSourceExist
        {
            get { return File.Exists(Application.StartupPath + EncryptedXmlSettingsFile); }
        }
        
        public static bool Initialize(string password)
        {
            try
            {
                Password = password;
                loadInstance();
                return true;
            }
            catch (Exception)
            {
                _instance = null;
                Password = null;
                return false;
            }
        }

        public static void RemoveEncryptedSource()
        {
            File.Delete(Application.StartupPath + EncryptedXmlSettingsFile);
        }

        #endregion

        #region Serialized data

        // Информация о хостах, отсортированная топологической сортировкой. Меньший индекс = меньше зависимостей.
        public List<HostInfo> Hosts { get; set; }

        #endregion

        public void Save()
        {
            var stream = new MemoryStream();
            XmlWriter writer = XmlWriter.Create(stream, new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = true});
            _serializer.Serialize(writer, this);
            writer.Flush();
            writer.Close();
            //var s = Encoding.UTF8.GetString(stream.ToArray());

            if (SettingsSource == ESettingsSource.ExplicitXml)
            {
                stream.Seek(0, SeekOrigin.Begin);
                using (var explicitXmlStream = File.Open(Application.StartupPath + ExplicitXmlSettingsFile, FileMode.Create, FileAccess.Write))
                    stream.CopyTo(explicitXmlStream);
            }

            updateEncryptedXmlFile(stream);
        }

        public void ChangePassword(string newPassword)
        {
            Password = newPassword;
            Save();
        }

        private static void updateEncryptedXmlFile(Stream xmlStream)
        {
            using (var encryptedXmlStream = File.Open(Application.StartupPath + EncryptedXmlSettingsFile, FileMode.Create, FileAccess.Write))
            {
                xmlStream.Seek(0, SeekOrigin.Begin);
                CryptoHelper.EncryptAes(xmlStream, encryptedXmlStream, Password);
            }
        }

        private static EncryptedSettings loadSettings(Stream xmlStream)
        {
            var settings = (EncryptedSettings)_serializer.Deserialize(xmlStream);

            var hostsByName = settings.Hosts.ToDictionary(h => h.Name);
            // Установка связанных зависимостей
            foreach (var host in settings.Hosts.Where(h => !string.IsNullOrWhiteSpace(h.DependsOnStr)))
            {
                var depStr = host.DependsOnStr;
                if (!hostsByName.ContainsKey(depStr))
                {
                    throw new Exception(string.Format("Требуемый для работы хоста '{0}' хост '{1}' не найден.", host.Name, depStr));
                }
                host.DependsOn = hostsByName[depStr];
            }

            settings.Hosts = DevExpress.Utils.Algorithms.TopologicalSort(settings.Hosts, new HostInfoComparer()).Reverse().ToList();

            xmlStream.Seek(0, SeekOrigin.Begin);
            return settings;
        }

        private static Stream getXmlStream(string password)
        {
            Stream inputXml;
            var appPath = Application.StartupPath;
            switch (SettingsSource)
            {
            case ESettingsSource.ExplicitXml:
                inputXml = File.OpenRead(appPath + ExplicitXmlSettingsFile);
                break;
            case ESettingsSource.EncryptedXml:
                inputXml = new MemoryStream();
                using (var file = File.OpenRead(appPath + EncryptedXmlSettingsFile))
                    CryptoHelper.DecryptAes(file, inputXml, password);
                inputXml.Seek(0, SeekOrigin.Begin);
                break;
            case ESettingsSource.Invalid:
                throw new Exception("Config file or it`s encrypted equivalent not found.");
            default:
                throw new ArgumentOutOfRangeException();
            }
            inputXml.Seek(0, SeekOrigin.Begin);
            return inputXml;
        }

        private static void loadInstance()
        {
            if (string.IsNullOrWhiteSpace(Password))
            {
                throw new Exception("EncryptedSettings initialization error: password is empty.");
            }

            using (var inputXml = getXmlStream(Password))
            {
                _instance = loadSettings(inputXml);
                if (SettingsSource == ESettingsSource.ExplicitXml)
                    updateEncryptedXmlFile(inputXml);
            }
        }
    }*/
}
