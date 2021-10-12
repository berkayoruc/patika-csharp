using System;

namespace arayuzler
{
    public class FileLogger : ILogger
    {
        public void writeLog()
        {
            // throw new System.NotImplementedException();
            Console.WriteLine("file log");
        }
    }
}