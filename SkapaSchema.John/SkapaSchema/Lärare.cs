using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkapaSchema.Affärslager;

namespace SkapaSchema.Entiteter
{
    public class Lärare : person
    {
        
        public string telefonNummer;
        public string signatur;

        public Lärare(string telefonNummer, string signatur, string förnamn, string efternamn, string epost) : base(förnamn, efternamn, epost)
        {
            this.telefonNummer = telefonNummer;
            this.signatur = signatur;
            FörNamn = förnamn;
            EfterNamn = efternamn;
            Epost = epost;
            behörighet = BehörighetNivå.Lärare;
        }

        public Schema SkapaSchema()
        {
            return new(); //fyll i parametrar
        }

        public void VisaSchema(Schema schema) { SchemaKontroller. }

        public void TaBortSchema(Schema schema) { }

        public Schema UppdateraSchema(Schema schema) { return new(); }
        public ExaminationsMoment SkapaExaminationsMoment()
        {
            return new(); //fyll i parametrar
        }

        public Kurs SkapaKurs()
        {
            return new(); //fyll i parametrar
        }
    }
}
