using System;

namespace Oop3
{
    partial class DatabaseLoggerService
    {
       public class FileLoggerService : ILoggerService
        {
            public void Log()
            {
                Console.WriteLine("loged to file");
            }
        }
    }
}
