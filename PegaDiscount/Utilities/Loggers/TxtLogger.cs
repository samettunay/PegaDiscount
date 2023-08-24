using System;
using System.IO;


namespace PegaDiscount.Utilities.Loggers
{
    public class TxtLogger : ILogger
    {
        public void WriteLog(string message)
        {
            string logPath = "Logs/log.txt";
            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine($"{DateTime.Now} : {message}");
            }
        }
    }
}
