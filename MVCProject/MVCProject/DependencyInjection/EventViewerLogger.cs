using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace MVCProject.DependencyInjection
{
    public class EventViewerLogger : IErrorLogger
    {
        public void LogMessage(Exception ex)
        {
            EventLog objEventLog = new EventLog("Application");
            string sourceName = ConfigurationManager.AppSettings["App"];
            string logName = ConfigurationManager.AppSettings["LogName"];
            if (!(EventLog.SourceExists(sourceName)))
            {
                EventLog.CreateEventSource(sourceName, logName);
            }
            objEventLog.Source = sourceName;
            string message = String.Format("Message: {0} \n StackTrace: {1} \n Date/Time: {2} ", ex.Message, ex.StackTrace, DateTime.Now.ToString());
            objEventLog.WriteEntry(message, EventLogEntryType.Error);
        }
    }
}