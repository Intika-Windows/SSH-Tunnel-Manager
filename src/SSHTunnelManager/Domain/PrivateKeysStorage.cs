using System;
using System.Collections.Generic;
using System.Linq;
using SSHTunnelManager.Business;
using SSHTunnelManager.Util;

namespace SSHTunnelManager.Domain
{
    public static class PrivateKeysStorage
    {
        private static readonly Dictionary<HostInfo, List<PrivateKey>> _keysCache = 
            new Dictionary<HostInfo, List<PrivateKey>>();

        public static PrivateKey CreatePrivateKey(HostInfo host)
        {
            if (host == null)
            {
                throw new ArgumentNullException("host");
            }
            if (host.AuthType != AuthenticationType.PrivateKey)
            {
                throw new FormatException();
            }
            
            var key = new PrivateKey(host.PrivateKeyData);
            List<PrivateKey> values;
            if (_keysCache.TryGetValue(host, out values))
            {
                values.Add(key);
            } else
            {
                _keysCache.Add(host, new List<PrivateKey>() { key });
            }
            return key;
        }

        public static void RemovePrivateKey(HostInfo host)
        {
            List<PrivateKey> values;
            if (_keysCache.TryGetValue(host, out values))
            {
                foreach (var key in values)
                {
                    key.Dispose();
                }
                _keysCache.Remove(host);
            }
        }

        public static void CleanUpGarbage()
        {
            foreach (var z in _keysCache)
            {
                foreach (var key in z.Value)
                {
                    key.Dispose();
                }
            }
            _keysCache.Clear();
        }
    }
}
