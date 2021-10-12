using System;

namespace arayuzler
{
    public class SMSLogger : ILogger
    {
        public void writeLog()
        {
            // throw new System.NotImplementedException();
            Console.WriteLine("sms log");
        }
    }
}