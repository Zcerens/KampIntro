using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DataBaseLoggerService : ILoggerService //Veri tabanına log yapacak
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı.");
        }
    }
}
