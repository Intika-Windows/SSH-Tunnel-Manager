using System;

namespace SSHTunnelManager.Business
{
    [Serializable]
    public class Config
    {
        public Config()
        {
            RestartEnabled = true;
            RestartDelay = 0;
            MaxAttemptsCount = 3;
        }

        private volatile bool _restartEnabled;
        private volatile int _restartDelay;
        private volatile int _maxAttemptsCount;

        /// <summary>
        /// AutoRestart successfully started connections if they have ended unexpectedly.
        /// </summary>
        public bool RestartEnabled
        {
            get { return _restartEnabled; }
            set { _restartEnabled = value; }
        }

        /// <summary>
        /// Delay before autoRestart (in seconds).
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
    }
}