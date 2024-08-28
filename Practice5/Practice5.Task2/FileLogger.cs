using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task2
{
    public class FileLogger : ILogger
    {
        private readonly string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Trace(string message) => Log(message, LogLevel.Trace);
        public void Info(string message) => Log(message, LogLevel.Trace);
        public void Debug(string message) => Log(message, LogLevel.Trace);
        public void Warning(string message) => Log(message, LogLevel.Trace);
        public void Error(string message) => Log(message, LogLevel.Trace);
        public void Fatal(string message) => Log(message, LogLevel.Trace);
        public void Log(string message, LogLevel logLevel)
        {
            string logMessage = $"{DateTime.Now} | {GetType().Name} | {logLevel} | {message}";
            File.AppendAllText(_filePath, logMessage + Environment.NewLine);
        }

    }
}
