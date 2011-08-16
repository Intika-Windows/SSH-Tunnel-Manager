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
        /// � ������, ���� ������� ������� ���������� (������� AsyncStart), ������� ����� ����������� �� ������������ ������.
        /// ������� ����� ��������� Threadsafe, ��� ��������� ��������� ����� ����� ������������ Control.BeginInvoke()
        /// </summary>
        event EventHandler LinkStatusChanged;

        void AsyncStart();
        void Start();
        void Stop();
        bool WaitForStop(int seconds = 10);
        bool WaitForStart(int seconds = 20);
    }
}