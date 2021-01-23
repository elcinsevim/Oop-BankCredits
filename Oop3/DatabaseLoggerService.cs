using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    partial class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("loged to database");
        }
    }
}
