using NLog; //Abhängigkeit!
using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_OLID
{
    //Negativbeispiel: Klasse Mitarbeiter kümmert sich nicht nur um
    //die Verwaltung von ihren Daten, sondern auch um das Loggen.
    public class Mitarbeiter_Negativ
    {
        private Logger _logger = null; //Abhängigkeit von Logger-Lib
        private string? name;
        public int Alter { get; set; }
        public E_STATUS Status { get; set; }
        public Mitarbeiter_Negativ(bool logToConsole)
        {
            if (logToConsole == false)
                _logger = LogManager.GetCurrentClassLogger();
            else
                Console.WriteLine("Es wird auf die Console geloggt.");
        }
        
        public string? Name
        {
            get => name;
            set
            {
                if (value == null)
                    _logger.Log(LogLevel.Info, "Der Name darf nicht NULL sein.");
                else
                    name = value;
            }
        }
    }
}
