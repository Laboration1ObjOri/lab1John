using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkapaSchema.Entiteter
{
    public class Kurs
    {
        public string kursNamn;
        public string kursKod;
        public Utbildning Utbildning;

        public List<ExaminationsMoment> ExaminationsMoment;

        public Kurs() { }
    }
}
