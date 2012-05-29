using System;
using System.Collections.Generic;
using System.Linq;
using SSHTunnelManager.Business;
using SSHTunnelManager.Util;

namespace SSHTunnelManager.Domain
{
    public static class PrivateKeysStorage
    {
        private static readonly Dictionary<HostInfo, PrivateKey> _keysCache = new Dictionary<HostInfo, PrivateKey>();

        public static PrivateKey GetPrivateKey(HostInfo host)
        {
            if (host == null)
            {
                throw new ArgumentNullException("host");
            }
            if (host.AuthType != AuthenticationType.PrivateKey)
            {
                throw new FormatException();
            }

            PrivateKey key;
            if (_keysCache.TryGetValue(host, out key) && !key.IsDisposed)
            {
                return key;
            }

            key = new PrivateKey(host.PrivateKeyData);
            _keysCache.Add(host, key);
            return key;
        }

        public static void RemovePrivateKey(HostInfo host)
        {
            PrivateKey key;
            if (_keysCache.TryGetValue(host, out key))
            {
                key.Dispose();
                _keysCache.Remove(host);
            }
        }

        public static void CleanUpGarbage()
        {
            foreach (var key in _keysCache)
            {
                key.Value.Dispose();
            }
            _keysCache.Clear();
        }
    }
}
