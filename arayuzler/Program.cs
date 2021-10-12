using System;

namespace arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.writeLog();

            DBLogger dBLogger = new DBLogger();
            dBLogger.writeLog();

            SMSLogger sMSLogger = new();
            sMSLogger.writeLog();


            LogManager logManager = new(new FileLogger());
            logManager.writeLog();
        }
    }
}
