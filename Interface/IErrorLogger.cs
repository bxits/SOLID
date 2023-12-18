using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IErrorLogger
    {
        public bool ErrorLoggedSuccessful { get;}
        void Log(string message);
    }
}
