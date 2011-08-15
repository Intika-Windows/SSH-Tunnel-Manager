using System;
using System.Runtime.Serialization;

namespace SSHTunnelManager.Domain
{
    public class EncryptedStorageException : Exception
    {
        public EncryptedStorageException() { }
        public EncryptedStorageException(string message) : base(message) { }
        public EncryptedStorageException(string message, Exception innerException) : base(message, innerException) { }
        protected EncryptedStorageException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}