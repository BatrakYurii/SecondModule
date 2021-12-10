using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule
{
    public class Logger
    {
        private static Logger _logger;
        private static StringBuilder _sb = new StringBuilder();

        private Logger()
        {

        }
        public static Logger Intance
        {
            get
            {
                return _logger ?? new Logger();
            }
        }
        public void Log(TypeLog loglevel, string message)
        {
            var logMessage = $"Date: {DateTime.UtcNow}. {{{loglevel}}}. Message: {message}";
            _sb.AppendLine(logMessage);
            Console.WriteLine(logMessage);
        }
        public string GetAllLogs()
        {
            return _sb.ToString();
            
        }
    }
}
