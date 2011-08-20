using System;

namespace SSHTunnelManager.Domain
{
    public enum ELinkStatus
    {
        Stopped,
        Starting,
        Waiting,
        Started,
        StartedWithWarnings
    }
}