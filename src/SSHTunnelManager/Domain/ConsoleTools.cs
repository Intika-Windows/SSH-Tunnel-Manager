using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SSHTunnelManager.Business;

namespace SSHTunnelManager.Domain
{
    public class ConsoleTools
    {
        public const string PLinkLocation = "plink.exe";

        public static string PuttyArguments(HostInfo host, PuttyProfile profile, bool withPassword)
        {
            // example: -ssh -load _stm_preset_ username@domainName -P 22 -pw password -D 5000 -L 44333:username.dyndns.org:44333

            string profileArg = "";
            if (profile != null)
            {
                profileArg = " -load " + profile.Name;
            }

            var args = withPassword
                           ? String.Format("-ssh{0} {1}@{2} -P {3} -pw {4} -v", profileArg, host.Username, host.Hostname, host.Port, host.Password)
                           : String.Format("-ssh{0} {1}@{2} -P {3} -v", profileArg, host.Username, host.Hostname, host.Port);
            var sb = new StringBuilder(args);
            foreach (var tunnelArg in host.Tunnels.Select(tunnelArguments))
            {
                sb.Append((string) tunnelArg);
            }

            args = sb.ToString();
            return args;
        }

        public static string PsftpArguments(HostInfo host)
        {
            var args = String.Format("{0}@{1} -P {2} -pw {3} -batch", host.Username, host.Hostname, host.Port, host.Password);
            return args;
        }

        private static string tunnelArguments(TunnelInfo tunnel)
        {
            if (tunnel == null) throw new ArgumentNullException("tunnel");
            switch (tunnel.Type)
            {
            case TunnelType.Local:
                return String.Format(@" -L {0}:{1}:{2}", tunnel.LocalPort, tunnel.RemoteHostname, tunnel.RemotePort);
            case TunnelType.Remote:
                return String.Format(@" -R {0}:{1}:{2}", tunnel.LocalPort, tunnel.RemoteHostname, tunnel.RemotePort);
            case TunnelType.Dynamic:
                return String.Format(@" -D {0}", tunnel.LocalPort);
            default:
                throw new FormatException("Invalid tunnel type.");
            }
        }
    }
}
