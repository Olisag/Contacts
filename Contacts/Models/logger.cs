using Contacts.Models.contracts;
using log4net;
using System;

namespace Contacts.Models
{
    public class Logger: ILogger
    {
        private ILog Log { get; set; }

        public Logger()
        {
            Log = LogManager.GetLogger(typeof(Logger));
        }

        public void Error(object msg)
        {
            Log.Error(msg);
        }

        public void Error(object msg, Exception ex)
        {
            Log.Error(msg, ex);
        }

        public void Error(Exception ex)
        {
            Log.Error(ex.Message, ex);
        }

        public void Info(object msg)
        {
            Log.Info(msg);
        }
    }
}