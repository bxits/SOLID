using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_O_LID
{
    public class Rechnung
    {
        public virtual double BerechneRabatt(double rechnungsBetrag)
        {
            return rechnungsBetrag * 0.005;
        }
    }

    public class EndRechnung : Rechnung
    {
        public override double BerechneRabatt(double rechnungsBetrag)
        {
            return base.BerechneRabatt(rechnungsBetrag) * 0.19;
        }
    }

    public class ZwischenRechnung : Rechnung
    {
        public override double BerechneRabatt(double rechnungsBetrag)
        {
            return base.BerechneRabatt(rechnungsBetrag) * 0.08;
        }
    }

    public class KleinstRechnung : Rechnung
    {
        public override double BerechneRabatt(double rechnungsBetrag)
        {
            return base.BerechneRabatt(rechnungsBetrag) * 0.01;
        }
    }
}
