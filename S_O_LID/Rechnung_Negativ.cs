using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_O_LID
{
    public class Rechnung_Negativ
    {
        //Verletzung des Closed-Prinzips: Der Quellcode der bereits fertigen Methode
        //musste in Sprint 2 und 3 angepasst werden. -> Fehler in der Erweiterung können sich auf die
        //alten, bereits fertigen Funktionen auswirken.
        public double BerechneRabatt(double rechnungsBetrag, E_RECHNUNGS_TYP rt) //Enum eingeführt ab Sprint 2
        {
            var rabatt = rechnungsBetrag * 0.005; //Grundrabatt

            switch (rt)
            {
                case E_RECHNUNGS_TYP.eEndRechnung:
                    rabatt = rechnungsBetrag * 0.19; //19% Rabatt //Ursprüngliche Anforderung
                    break;
                case E_RECHNUNGS_TYP.eZwischenRechnung:
                    rabatt = rechnungsBetrag * 0.08; //8% Rabatt //Neue Anforderung aus Sprint 2
                    break;
                case E_RECHNUNGS_TYP.eKleinstRechnung:
                    rabatt = rechnungsBetrag * 0.01; //1% Rabatt //Erneute Anforderung aus Sprint 3
                    break;
                default:
                    rabatt = 0.0;
                    break;
            }
            return rabatt;
        }
    }
}
