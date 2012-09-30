using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using SSHTunnelManager.Properties;
using SSHTunnelManager.Util;
using log4net.Util.TypeConverters;

namespace SSHTunnelManager.Domain
{
    public class PuttyProfile
    {
        private static readonly Dictionary<string, PuttyProfileProperty> _defaultProfileProperties;

        static PuttyProfile()
        {
            _defaultProfileProperties = Resources.defaultPuttyProfile.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries).Skip(3).
                Select(parseLine).Except(new PuttyProfileProperty[] { null }).ToDictionary(p => p.Name);
        }

        private static PuttyProfileProperty parseLine(string line)
        {
            var m = Regex.Match(line, @"((?<name>[^""=]+)|""(?<name>([^""]|(?<=\\)"")+)"")=(((?<type>\w+):)?(?<value>[^""=]*)|""((?<type>\w+:)?(?<value>([^""]|(?<=\\)"")*))"")");
            if (!m.Success)
            {
                return null;
            }

            var name = m.Groups["name"].Value.Replace(@"\""", @"""");
            var value = m.Groups["value"].Value.Replace(@"\""", @"""");
            var type = m.Groups["type"].Value;
            object resValue;
            PropertyType resType;
                
            if (string.IsNullOrEmpty(type))
            {
                resValue = value;
                resType = PropertyType.String;
            } else if (type == @"dword")
            {
                resValue = int.Parse(value, NumberStyles.AllowHexSpecifier);
                resType = PropertyType.Int32;
            }
            else
            {
                throw new NotSupportedException();
            }

            return new PuttyProfileProperty(name) { Value = resValue, Type = resType };
        }

        private PuttyProfile()
        {
            Properties = new Dictionary<string, PuttyProfileProperty>();
        }

        public enum ProxyType
        {
            None = 0,
            Socks4 = 1,
            Socks5 = 2,
            Http = 3
        }

        #region Constructors

        public static PuttyProfile ReadProfile(string profileName)
        {
            if (profileName == null) throw new ArgumentNullException("profileName");
            try
            {
                using (RegistryKey profileKey = Registry.CurrentUser.OpenSubKey(@"Software\SimonTatham\PuTTY\Sessions\" + profileName, false))
                {
                    if (profileKey == null)
                    {
                        Logger.Log.Info(Resources.PuttyProfile_ProfileNotFound);
                        return null;
                    }

                    if (_defaultProfileProperties.Select(v => v.Key).Except(profileKey.GetValueNames()).Any())
                    {
                        Logger.Log.Info(Resources.PuttyProfile_NotAllPropertiesSet);
                        return null;
                    }

                    var profile = new PuttyProfile {Name = profileName};
                    foreach (var name in profileKey.GetValueNames())
                    {
                        var value = profileKey.GetValue(name);
                        var kind = profileKey.GetValueKind(name);
                        PropertyType type;
                        switch (kind)
                        {
                            case RegistryValueKind.String:
                                type = PropertyType.String;
                                break;
                            case RegistryValueKind.DWord:
                                type = PropertyType.Int32;
                                break;
                            default:
                                throw new NotSupportedException(Resources.PuttyProfile_Error_RegistryValueKindNotSupported);
                        }
                        profile.Properties[name] = new PuttyProfileProperty(name) { Value = value, Type = type };
                    }
                    return profile;
                }
            }
            catch (SecurityException e)
            {
                throw new SSHTunnelManagerException(
                    string.Format(Resources.PuttyProfile_Error_SecurityException2, profileName, e.Message), e);
            }
        }

        public static PuttyProfile CreateProfile(string profileName)
        {
            if (profileName == null) throw new ArgumentNullException("profileName");
            saveProperties(profileName, _defaultProfileProperties);
            return ReadProfile(profileName);
        }

        private static void saveProperties(string profileName, Dictionary<string, PuttyProfileProperty> profileProperties)
        {
            try
            {
                using (RegistryKey profileKey = Registry.CurrentUser.
                       CreateSubKey(@"Software\SimonTatham\PuTTY\Sessions\" + profileName,
                                    RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    if (profileKey == null)
                    {
                        throw new SSHTunnelManagerException(
                            string.Format(Resources.PuttyProfile_Error_CreateSubKeyReturnedNull, profileName));
                    }

                    foreach (var property in profileProperties.Values)
                    {
                        RegistryValueKind kind;
                        switch (property.Type)
                        {
                        case PropertyType.String:
                            kind = RegistryValueKind.String;
                            break;
                        case PropertyType.Int32:
                            kind = RegistryValueKind.DWord;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                        }
                        profileKey.SetValue(property.Name, property.Value, kind);
                    }
                }
            }
            catch (SecurityException e)
            {
                throw new SSHTunnelManagerException(
                    string.Format(Resources.PuttyProfile_Error_SecurityException, profileName, e.Message), e);
            }
            catch (UnauthorizedAccessException e)
            {
                throw new SSHTunnelManagerException(
                    string.Format(Resources.PuttyProfile_Error_UnauthorizedAccessException, profileName, e.Message), e);
            }
            catch (IOException e)
            {
                throw new SSHTunnelManagerException(
                    string.Format(Resources.PuttyProfile_Error_IOException, profileName, e.Message), e);
            }
        }

        public static PuttyProfile ReadOrCreate(string profileName)
        {
            return ReadProfile(profileName) ?? CreateProfile(profileName);
        }

        #endregion

        #region Properties

        public string Name { get; private set; }
        public Dictionary<string, PuttyProfileProperty> Properties { get; private set; }

        public bool LocalPortAcceptAll
        {
            get { return getBool(@"LocalPortAcceptAll"); }
            set { setBool(@"LocalPortAcceptAll", value); }
        }

        public bool RemotePortAcceptAll
        {
            get { return getBool(@"RemotePortAcceptAll"); }
            set { setBool(@"RemotePortAcceptAll", value); }
        }

        public ProxyType ProxyMethod
        {
            get { return (ProxyType)(int)getOrCreate(@"ProxyMethod").Value; }
            set
            {
                if (value == ProxyMethod)
                    return;

                getOrCreate(@"ProxyMethod").Value = (int)value;
            }
        }

        public string ProxyHost
        {
            get { return getString(@"ProxyHost"); }
            set { setString(@"ProxyHost", value); }
        }

        public int ProxyPort
        {
            get { return getInt(@"ProxyPort"); }
            set { setInt(@"ProxyPort", value); }
        }

        public string ProxyUsername
        {
            get { return getString(@"ProxyUsername"); }
            set { setString(@"ProxyUsername", value); }
        }

        public string ProxyPassword
        {
            get { return getString(@"ProxyPassword"); }
            set { setString(@"ProxyPassword", value); }
        }

        /// <summary>
        /// Consider proxying local host connections
        /// </summary>
        public bool ProxyLocalhost
        {
            get { return getBool(@"ProxyLocalhost"); }
            set { setBool(@"ProxyLocalhost", value); }
        }

        public string ProxyExcludeList
        {
            get { return getString(@"ProxyExcludeList"); }
            set { setString(@"ProxyExcludeList", value); }
        }

        #endregion

        public void Save()
        {
            saveProperties(Name, Properties);
        }

        private PuttyProfileProperty getOrCreate(string name)
        {
            PuttyProfileProperty property;
            if (!Properties.TryGetValue(name, out property))
            {
                return Properties[name] = new PuttyProfileProperty(name);
            }
            return property;
        }

        private void setString(string name, string value)
        {
            if (getString(name) == value)
                return;

            getOrCreate(name).Value = value;
        }

        private string getString(string name)
        {
            return (string) getOrCreate(name).Value;
        }

        private void setInt(string name, int value)
        {
            if (getInt(name) == value)
                return;

            getOrCreate(name).Value = value;
        }

        private int getInt(string name)
        {
            return (int) getOrCreate(name).Value;
        }

        private void setBool(string name, bool value)
        {
            if (getBool(name) == value)
                return;

            getOrCreate(name).Value = Convert.ToInt32(value);
        }

        private bool getBool(string name)
        {
            return ((int)getOrCreate(name).Value) != 0;
        }
    }
}
