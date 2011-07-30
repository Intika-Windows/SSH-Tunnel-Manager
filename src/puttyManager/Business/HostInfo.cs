using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using PuttyManager.Domain;

namespace PuttyManager.Business
{
    [Serializable]
    public class HostInfo
    {
        private readonly List<TunnelInfo> _tunnels = new List<TunnelInfo>();
        private HostInfo _dependsOn;

        [XmlAttribute]
        public string Name { get; set; }
        public string Hostname { get; set; }
        public string MachineName { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<TunnelInfo> Tunnels
        {
            get { return _tunnels; }
        }

        private string _dependsOnStr;
        public string DependsOnStr
        {
            get
            {
                if (DependsOn != null)
                {
                    DependsOnStr = DependsOn.Name;
                }
                return _dependsOnStr;
            }
            set { _dependsOnStr = value; }
        }

        [XmlIgnore]
        public HostInfo DependsOn
        {
            get { return _dependsOn; }
            set
            {
                _dependsOn = value;
                DependsOnStr = value != null ? value.Name : null;
            }
        }

        public bool DeepDependsOn(HostInfo host)
        {
            if (host == null) throw new ArgumentNullException("host");

            for (HostInfo dependency = DependsOn; dependency != null; dependency = dependency.DependsOn)
            {
                if (dependency == host)
                {
                    return true;
                }
            }
            return false;
        }

        public string HostAndPort { get { return string.Format("{0}:{1}", Hostname, Port); } }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (HostInfo) obj;
            var x = uniqString();
            var y = other.uniqString();
            return x.Equals(y);
        }

        public override int GetHashCode()
        {
            return uniqString().GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}:{2})", Name, Hostname, Port);
        }

        private string uniqString()
        {
            return string.Format("{0}:{1}", Hostname, Port);
        }
    }
}