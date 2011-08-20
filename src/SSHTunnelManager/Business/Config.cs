using System;

namespace SSHTunnelManager.Business
{
    [Serializable]
    public class Config
    {
        public Config()
        {
            RestartEnabled = true;
            RestartDelay = 30;
            MaxAttemptsCount = 3;
            DelayInsteadStop = true;
            RestartHostsWithWarnings = false;
            RestartHostsWithWarningsInterval = 300;
        }

        private volatile bool _restartEnabled;
        private volatile int _restartDelay;
        private volatile int _maxAttemptsCount;
        private volatile bool _delayInsteadStop;
        private volatile bool _restartHostsWithWarnings;
        private volatile int _restartHostsWithWarningsInterval;

        /// <summary>
        /// AutoRestart successfully started connections if they have ended unexpectedly.
        /// </summary>
        public bool RestartEnabled
        {
            get { return _restartEnabled; }
            set { _restartEnabled = value; }
        }

        /// <summary>
        /// Delay before autoRestart (in seconds) after MaxAttemptsCount fails.
        /// </summary>
        public int RestartDelay
        {
            get { return _restartDelay; }
            set { _restartDelay = value; }
        }

        /// <summary>
        /// Maximum restart attempts after fail.
        /// </summary>
        public int MaxAttemptsCount
        {
            get { return _maxAttemptsCount; }
            set { _maxAttemptsCount = value; }
        }

        /// <summary>
        /// Do not stop after MaxAttemptsCount, just make delay.
        /// </summary>
        public bool DelayInsteadStop
        {
            get { return _delayInsteadStop; }
            set { _delayInsteadStop = value; }
        }

        /// <summary>
        /// If host started with warnings, periodically try to reconnect.
        /// </summary>
        public bool RestartHostsWithWarnings
        {
            get { return _restartHostsWithWarnings; }
            set { _restartHostsWithWarnings = value; }
        }

        /// <summary>
        /// Interval between reconnects (in seconds)
        /// </summary>
        public int RestartHostsWithWarningsInterval
        {
            get { return _restartHostsWithWarningsInterval; }
            set { _restartHostsWithWarningsInterval = value; }
        }
    }
}