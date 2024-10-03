using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkapaSchema.Entiteter
{
    public class SchemaRad
    {
        public DateTime datum;
        public TimeOnly startTid;
        public TimeOnly slutTid;
        public string moment;
        public KursTillfälle kursTillfälle;
        public List<string> LärareSignum;

        public SchemaRad() { }
    }
}
