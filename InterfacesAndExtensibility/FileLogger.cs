using System;
using System.IO;

namespace InterfacesAndExtensibility 
{
    public enum MessageType
    {
        ERROR = 1,
        INFO = 2
    };

    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                Log(message, Convert.ToString(MessageType.ERROR));
            }
        }

        public void LogInfo(string message)
        {
            Log(message, Convert.ToString(MessageType.INFO));
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}