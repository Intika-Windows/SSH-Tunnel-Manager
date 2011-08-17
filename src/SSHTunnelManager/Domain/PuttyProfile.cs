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
            } else if (type == "dword")
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
                        Logger.Log.Info("Profile not found.");
                        return null;
                    }

                    if (_defaultProfileProperties.Select(v => v.Key).Except(profileKey.GetValueNames()).Count() > 0)
                    {
                        Logger.Log.Info("Invalid profile: not all properties set.");
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
                                throw new NotSupportedException("Registry value kind is not supported.");
                        }
                        profile.Properties[name] = new PuttyProfileProperty(name) { Value = value, Type = type };
                    }
                    return profile;
                }
            }
            catch (SecurityException e)
            {
                throw new SSHTunnelManagerException(
                    string.Format("Security error while reading PuTTY profile {0}: {1}", profileName, e.Message), e);
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
                            string.Format("Error while creating TuTTY profile {0}: unknown error.", profileName));
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
                    string.Format("Security error while updating PuTTY profile {0}: {1}", profileName, e.Message), e);
            }
            catch (UnauthorizedAccessException e)
            {
                throw new SSHTunnelManagerException(
                    string.Format("UnauthorizedAccess error while updating PuTTY profile {0}: {1}", profileName, e.Message), e);
            }
            catch (IOException e)
            {
                throw new SSHTunnelManagerException(
                    string.Format("IO error while updating PuTTY profile {0}: {1}", profileName, e.Message), e);
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
            get { return (int) getOrCreate("LocalPortAcceptAll").Value != 0; }
            set
            {
                if (value == LocalPortAcceptAll)
                    return;

                getOrCreate("LocalPortAcceptAll").Value = Convert.ToInt32(value);
            }
        }

        public bool RemotePortAcceptAll
        {
            get { return (int)getOrCreate("RemotePortAcceptAll").Value != 0; }
            set
            {
                if (value == RemotePortAcceptAll)
                    return;

                getOrCreate("RemotePortAcceptAll").Value = Convert.ToInt32(value);
            }
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
                return Properties["LocalPortAcceptAll"] = new PuttyProfileProperty(name);
            }
            return property;
        }
    }
}
