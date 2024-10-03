using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SkapaSchema.Entiteter
{
  
   
    public class Utbildning
    {
        public string UtbildningsNamn;
        public DateOnly startÅr;
        public DateOnly slutÅr;
        public Termin startTermin;
        public string akronym;
        public List<Kurs> kurser;

        public Utbildning(string utbildningsNamn, DateOnly startår, DateOnly slutår, Kurs kurs, Termin starttermin) 
        {
            UtbildningsNamn = utbildningsNamn;
            startÅr = startår;
            slutÅr = slutår;
            startTermin = starttermin;
            kurser?.Add(kurs);
            akronym = skapaAkronym(this.UtbildningsNamn, this.startTermin, this);




        }

        public string SkapaAkronym(string utbildningsNamn, Termin termin, DateOnly startår)
        {
            utbildningsNamn.Trim();
            string terminBokstav;
            string årString = startår.Year.ToString().Substring(2, 2);
            string akronym;

            string prefix = utbildningsNamn.Length >= 3 ? utbildningsNamn.Substring(0, 3).ToUpper() : utbildningsNamn.ToUpper();

            if (termin == Termin.Vår)
            {
                terminBokstav = "V";
                Random random = new Random();
                int randomNummer = random.Next(1, 100);
                akronym = $"{prefix}{årString}{randomNummer}{terminBokstav}";

                return akronym;
            }
            else if (termin == Termin.Höst)
            {
                terminBokstav = "H";
                int randomNummer = random.Next(1, 100);
                akronym = $"{prefix}{årString}{randomNummer}{terminBokstav}";

                return akronym;
            }
            else
            {
                return "";
            }
          
        }
        

    }
}
