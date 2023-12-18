using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_OLID
{
    //Positivbeispiel: die Klasse Mitarbeiter erhält lediglich ein Objekt,
    //das einen Logger zur Verfügung stellt. Sie muss sich nicht um das
    //Loggen selbst kümmern.
    public class Mitarbeiter
    {
        IErrorLogger _logger;
        private string? name;
        public int Alter { get; set; }
        public E_STATUS Status { get; set; }
        
        public Mitarbeiter(IErrorLogger ding) 
        {
            _logger = ding;
        }    
        
        public string? Name { get => name; 
            set
            {
                if (value == null)
                    _logger.Log("Der Name darf nicht NULL sein.");
                else
                    name = value;
            }
        }
        
    }
}
