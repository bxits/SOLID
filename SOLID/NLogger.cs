using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_OLID
{
    public class ErrorLogger : IErrorLogger
    {
        private NLog.Logger _logger;
        private bool _ok;
        public ErrorLogger()
        {
            _logger = NLog.LogManager.GetCurrentClassLogger();
        }

        public bool LoggingOK { get => _ok; set => _ok = value; }

        /// <summary>
        /// Log Messages als "Error".
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            _logger.Error(message);
        }
    }
}
