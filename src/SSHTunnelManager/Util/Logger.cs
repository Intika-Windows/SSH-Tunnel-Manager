using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using SSHTunnelManager.Domain;
using SSHTunnelManager.Properties;
using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Repository.Hierarchy;

// log4net config.
// Assembly attribute should be in assembly where log4net methods was called first time (LogManager.GetLogger in this case).
// App.config log4net section should be in exec file.
[assembly: log4net.Config.XmlConfigurator]

namespace SSHTunnelManager.Util
{
    public class Logger
    {
        private static readonly ILog _log = LogManager.GetLogger("root");

        public static ILog Log
        {
            get { return _log; }
        }

        public static void SetThresholdForAppender(string appenderName, Level threshold)
        {
            var appender = (AppenderSkeleton) GetAppender(appenderName);

            appender.Threshold = threshold;
            appender.ActivateOptions();
            return;
        }

        public static IAppender GetAppender(string appenderName)
        {
            Hierarchy hier = LogManager.GetRepository() as Hierarchy;
            if (hier == null)
                throw new SSHTunnelManagerException(Resources.Logger_Error_GetRepository);

            var appender = (DelegateAppender)hier.GetAppenders().SingleOrDefault(a => a.Name == appenderName);
            if (appender == null)
                throw new SSHTunnelManagerException(string.Format(Resources.Logger_Error_GetAppender, appenderName));

            return appender;
        }
    }

    public class LogAppendedEventArgs : EventArgs
    {
        public LogAppendedEventArgs(string appendedData, Dictionary<string, object> properties, Level level)
        {
            AppendedData = appendedData;
            Properties = properties;
            Level = level;
        }

        public string AppendedData { get; private set; }
        public Dictionary<string, object> Properties { get; private set; }
        public Level Level { get; private set; }
    }

    public class DelegateAppender : AppenderSkeleton
    {
        public event EventHandler<LogAppendedEventArgs> OnAppend;
        public ISynchronizeInvoke SyncObject { get; set; }

        protected override void Append(LoggingEvent loggingEvent)
        {
            try
            {
                var renderedMessage = RenderLoggingEvent(loggingEvent);
                var properties = loggingEvent.GetProperties().Cast<DictionaryEntry>().ToDictionary(e => e.Key.ToString(), e => e.Value);
                if (OnAppend != null)
                {
                    var ea = new LogAppendedEventArgs(renderedMessage, properties, loggingEvent.Level);
                    if (SyncObject == null || !SyncObject.InvokeRequired)
                    {
                        OnAppend(this, ea);
                    }
                    else
                    {
                        SyncObject.Invoke(OnAppend, new object[] { this, ea });
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
