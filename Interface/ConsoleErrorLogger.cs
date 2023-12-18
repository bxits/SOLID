using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class ConsoleErrorLogger : IErrorLogger
    {
        public bool ErrorLoggedSuccessful => throw new NotImplementedException();

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
