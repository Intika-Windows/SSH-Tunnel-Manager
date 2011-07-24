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
    public class EncryptedSettings
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
    }
}
