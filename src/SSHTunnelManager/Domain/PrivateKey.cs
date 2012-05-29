using System;
using System.IO;
using System.Text;
using SSHTunnelManager.Util;

namespace SSHTunnelManager.Domain
{
    public class PrivateKey : IDisposable
    {
        private bool _disposed = false;

        private string _filename;
        public string Filename
        {
            get
            {
                if (_disposed)
                {
                    throw new ObjectDisposedException("PrivateKey");
                }
                return _filename;
            }
            private set { _filename = value; }
        }

        public bool IsDisposed
        {
            get { return _disposed; }
        }

        public PrivateKey(string content)
        {
            Filename = Path.GetTempFileName();
            File.WriteAllText(Filename, content, Encoding.ASCII);
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                File.Delete(Filename);
                Logger.Log.DebugFormat("Temporarily created private Key file '{0}' has been deleted.", Filename);
                _disposed = true;
            }
        }
    }
}