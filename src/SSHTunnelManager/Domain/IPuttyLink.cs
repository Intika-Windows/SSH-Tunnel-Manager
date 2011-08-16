using System;
using System.Collections.Generic;
using SSHTunnelManager.Business;

namespace SSHTunnelManager.Domain
{
    public interface IPuttyLink
    {
        HostInfo Host { get; }
        string LastStartError { get; }
        ELinkStatus Status { get; }
        Dictionary<TunnelInfo, ForwardingResult> ForwardingResults { get; }

        /// <summary>
        /// В случае, если процесс запущен асинхронно (методом AsyncStart), события будут срабатывать из асинхронного потока.
        /// Поэтому нужно продумать Threadsafe, для изменения состояния формы лучше использовать Control.BeginInvoke()
        /// </summary>
        event EventHandler LinkStatusChanged;

        void AsyncStart();
        void Start();
        void Stop();
        bool WaitForStop(int seconds = 10);
        bool WaitForStart(int seconds = 20);
    }
}