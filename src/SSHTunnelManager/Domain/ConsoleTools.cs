using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using SSHTunnelManager.Business;
using SSHTunnelManager.Properties;

namespace SSHTunnelManager.Domain
{
    public class ConsoleTools
    {
        public const string PLinkLocation = "Tools\\plink.exe";
        public const string PuttyLocation = "Tools\\putty.exe";
        public const string PsftpLocation = "Tools\\psftp.exe";
        public const string FileZillaLocation = "Tools\\FileZilla\\filezilla.exe";

        public static void StartPutty(HostInfo host, PuttyProfile profile)
        {
            var fileName = Path.Combine(Util.Helper.StartupPath, PuttyLocation);
            var args = PuttyArguments(host, profile, host.AuthType);
            Process.Start(fileName, args);
        }

        public static void StartPsftp(HostInfo host)
        {
            var fileName = Path.Combine(Util.Helper.StartupPath, PsftpLocation);
            var args = psftpArguments(host);
            Process.Start(fileName, args);
        }

        public static void StartFileZilla(HostInfo host)
        {
            var fileName = Path.Combine(Util.Helper.StartupPath, FileZillaLocation);
            var args = string.Format(@"sftp://{0}:{1}@{2}:{3}", host.Username, host.Password, host.Hostname, host.Port);
            Process.Start(fileName, args);
        }

        public static string PuttyArguments(HostInfo host, PuttyProfile profile, AuthenticationType authType)
        {
            // example: -ssh -load _stm_preset_ username@domainName -P 22 -pw password -D 5000 -L 44333:username.dyndns.org:44333

            string profileArg = "";
            if (profile != null)
            {
                profileArg = @" -load " + profile.Name;
            }

            string args;
            switch (authType)
            {
            case AuthenticationType.None:
                args = String.Format(@"-ssh{0} {1}@{2} -P {3} -v", profileArg, host.Username, host.Hostname, 
                                     host.Port);
                break;
            case AuthenticationType.Password:
                args = String.Format(@"-ssh{0} {1}@{2} -P {3} -pw {4} -v", profileArg, host.Username, host.Hostname,
                                     host.Port, host.Password);
                break;
            case AuthenticationType.PrivateKey:
                args = String.Format(@"-ssh{0} {1}@{2} -P {3} -i {4} -v", profileArg, host.Username, host.Hostname,
                                     host.Port, PrivateKeysStorage.GetPrivateKey(host).Filename);
                break;
            default:
                throw new ArgumentOutOfRangeException("authType");
            }
            var sb = new StringBuilder(args);
            foreach (var tunnelArg in host.Tunnels.Select(tunnelArguments))
            {
                sb.Append(tunnelArg);
            }

            args = sb.ToString();
            return args;
        }

        private static string psftpArguments(HostInfo host)
        {
            string args;
            switch (host.AuthType)
            {
            case AuthenticationType.Password:
                args = String.Format(@"{0}@{1} -P {2} -pw {3} -batch", host.Username, host.Hostname, host.Port,
                                     host.Password);
                break;
            case AuthenticationType.PrivateKey:
                args = String.Format(@"{0}@{1} -P {2} -i {3} -batch", host.Username, host.Hostname, host.Port,
                                     PrivateKeysStorage.GetPrivateKey(host).Filename);
                break;
            default:
                throw new ArgumentOutOfRangeException("authType");
            }
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
                throw new FormatException(Resources.ConsoleTools_Error_InvalidTunnelType);
            }
        }
    }
}
