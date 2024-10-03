using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkapaSchema.Entiteter
{
    enum Saltyp
    {
        Hörsal,
        Lärosal,
        Datorsal,
        grupprum,
    }
    public class Sal
    {
        public string SalID;
        public Saltyp saltyp;
        public bool bokningsStatus;

        public Sal() { }

        public Sal BokaSal(string salID)
        {
        }
    }
}
