using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using log4net.Core;

// log4net config.
// Assembly attribute should be in assembly where log4net methods was called first time (LogManager.GetLogger in this case).
// App.config log4net section should be in exec file.
[assembly: log4net.Config.XmlConfigurator]

namespace PuttyManager.Util
{
    public class Logger
    {
        private static readonly ILog _log = LogManager.GetLogger("root");

        public static ILog Log
        {
            get { return _log; }
        }
    }

    public class LogAppendedEventArgs : EventArgs
    {
        public LogAppendedEventArgs(string appendedData)
        {
            AppendedData = appendedData;
        }

        public string AppendedData { get; private set; }
    }

    public class DelegateAppender : log4net.Appender.AppenderSkeleton
    {
        public static event EventHandler<LogAppendedEventArgs> OnAppend;

        protected override void Append(LoggingEvent loggingEvent)
        {
            if (OnAppend != null)
            {
                OnAppend(this, new LogAppendedEventArgs(RenderLoggingEvent(loggingEvent)));
            }
        }
    }
}
