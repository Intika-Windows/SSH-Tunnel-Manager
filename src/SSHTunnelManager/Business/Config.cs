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
        }

        private volatile bool _restartEnabled;
        private volatile int _restartDelay;
        private volatile int _maxAttemptsCount;
        private volatile bool _delayInsteadStop;

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
    }
}