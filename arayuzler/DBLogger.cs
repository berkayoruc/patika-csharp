using System;

namespace arayuzler
{
    public class DBLogger : ILogger
    {
        public void writeLog()
        {
            // throw new System.NotImplementedException();
            Console.WriteLine("db log");
        }
    }
}