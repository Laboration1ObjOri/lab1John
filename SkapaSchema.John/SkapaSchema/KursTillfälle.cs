using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkapaSchema.Entiteter
{
    public class KursTillfälle
    {
        public DateTime datum;
        public TimeOnly startTid;
        public TimeOnly slutTid;
        public DateTime startDatum;
        public DateTime slutDatum;
        public Lärare kursAnsvarig;

        public Sal sal;
        public Kurs kurs;
       
    }
}
