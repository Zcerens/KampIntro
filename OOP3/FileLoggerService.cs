using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService //Dosyaya log yapacak
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
