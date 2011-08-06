
namespace PuttyManager.Business
{
    public enum TunnelType
    {
        Local,
        Remote,
        Dynamic
    }

    public enum HostStatus
    {
        Stopped,
        Unknown,
        StartedWithWarnings,
        Started
    }
}