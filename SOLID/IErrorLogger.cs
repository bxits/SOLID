using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_OLID
{
    public interface IErrorLogger //vgl. abstract Class
    {
        //Verpflichtung:

        //1. 
        public bool LoggingOK { get; set; }
        void Log(string message);   
    }
}
