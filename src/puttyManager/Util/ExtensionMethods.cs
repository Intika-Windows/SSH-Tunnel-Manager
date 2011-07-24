using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PuttyManager.Util
{
    public static class ExtensionMethods
    {
        public static MemoryStream ToMemoryStream(this string source)
        {
            return source.ToMemoryStream(Encoding.UTF8);
        }
        
        public static MemoryStream ToMemoryStream(this string source, Encoding encoding)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (encoding == null) throw new ArgumentNullException("encoding");

            var bytes = encoding.GetBytes(source);
            var stream = new MemoryStream();
            stream.Write(bytes, 0, bytes.Length);
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }
    }
}
