using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkapaSchema.Entiteter
{
    public class person
    {
        public string FörNamn;
        public string EfterNamn;
        public string Epost;
        public BehörighetNivå behörighet;

        public person(string förnamn, string efternamn, string epost)
        {
            FörNamn = förnamn;
            EfterNamn = efternamn;
            Epost = epost;
        }
    }
}
