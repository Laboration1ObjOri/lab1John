using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkapaSchema.Entiteter
{
    public class ExaminationsMoment
    {
        public DateTime startDatum;
        public DateTime slutDatum;
        public float högskolepoäng;
        public string akronym;
        public Sal sal;


        public ExaminationsMoment (DateTime startDatum, DateTime slutDatum, float högskolepoäng, string akronym, Sal sal)
        {
            this.startDatum = startDatum;
            this.slutDatum = slutDatum;
            this.högskolepoäng = högskolepoäng;
            this.akronym = akronym;
            this.sal = sal;
        }
    }
}
