using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using SSHTunnelManager.Properties;
using SSHTunnelManager.Util;
using log4net.Util.TypeConverters;

namespace SSHTunnelManager.Domain
{
    public enum PropertyType
    {
        String,
        Int32
    }

    public class PuttyProfileProperty
    {
        public PuttyProfileProperty(string name)
        {
            if (name == null) throw new ArgumentNullException("name");
            Name = name;
        }

        public string Name { get; private set; }
        public object Value { get; set; }
        public PropertyType Type { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", Name, Value);
        }
    }

    [Serializable]
    public class SSHTunnelManagerException : Exception
    {
        public SSHTunnelManagerException() { }
        public SSHTunnelManagerException(string message) : base(message) { }
        public SSHTunnelManagerException(string message, Exception innerException) : base(message, innerException) { }
        protected SSHTunnelManagerException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }

    public class PuttyProfile
    {
        private static readonly Dictionary<string, PuttyProfileProperty> _defaultProfile;

        static PuttyProfile()
        {
            _defaultProfile = Resources.defaultPuttyProfile.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries).Skip(3).
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

        public static PuttyProfile ReadProfile(string profileName)
        {
            if (profileName == null) throw new ArgumentNullException("profileName");
            try
            {
                RegistryKey profileKey = Registry.CurrentUser.OpenSubKey(@"Software\SimonTatham\PuTTY\Sessions\" + profileName, false);
                if (profileKey == null)
                {
                    Logger.Log.Info("Profile not found.");
                    return null;
                }

                if (_defaultProfile.Select(v => v.Key).Except(profileKey.GetValueNames()).Count() > 0)
                {
                    Logger.Log.Info("Invalid profile: not all properties set.");
                    return null;
                }

                var profile = new PuttyProfile();
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
            catch (SecurityException e)
            {
                throw new SSHTunnelManagerException(
                    string.Format("Security error while reading PuTTY profile {0}: {1}", profileName, e.Message), e);
            }
        }

        public Dictionary<string, PuttyProfileProperty> Properties { get; private set; }
    }
}
