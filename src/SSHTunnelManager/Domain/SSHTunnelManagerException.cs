using System;
using System.Runtime.Serialization;

namespace SSHTunnelManager.Domain
{
    [Serializable]
    public class SSHTunnelManagerException : Exception
    {
        public SSHTunnelManagerException() { }
        public SSHTunnelManagerException(string message) : base(message) { }
        public SSHTunnelManagerException(string message, Exception innerException) : base(message, innerException) { }
        protected SSHTunnelManagerException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}