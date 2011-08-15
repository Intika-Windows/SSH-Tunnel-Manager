using System.Collections.Generic;

namespace SSHTunnelManager.Business
{
    public class HostInfoComparer : IComparer<HostInfo>
    {
        public int Compare(HostInfo x, HostInfo y)
        {
            if (x.DependsOn == y)
                return -1;
            if (y.DependsOn == x)
                return 1;
            return 0;
        }
    }
}