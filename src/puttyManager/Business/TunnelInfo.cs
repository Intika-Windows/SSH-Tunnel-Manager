using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace PuttyManager.Business
{
    [Serializable]
    public class TunnelInfo
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public TunnelType Type { get; set; }
        public string LocalPort { get; set; }
        public string RemoteHostname { get; set; }
        public string RemotePort { get; set; }

        public string SimpleString
        {
            get
            {
                var strType = Type.ToString()[0];
                var dstHost = Type == TunnelType.Dynamic ? "" : string.Format(":{0}:{1}", RemoteHostname, RemotePort);
                var ret = string.Format(@"{0}{1}{2}", strType, LocalPort, dstHost);
                return ret;
            }
        }

        public override string ToString()
        {
            var strType = Type == TunnelType.Local ? "L" : (Type == TunnelType.Remote ? "R" : "D");
            var dstHost = Type == TunnelType.Dynamic ? "" : string.Format(" {0}:{1}", RemoteHostname, RemotePort);
            var srcPort = strType + LocalPort;
            var ret = string.Format(@"{0} [ {1}{2} ]", Name, srcPort, dstHost);
            return ret;
        }
    }
}