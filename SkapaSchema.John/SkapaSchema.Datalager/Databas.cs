using SkapaSchema.Entiteter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkapaSchema.Datalager
{
    public class Databas
    {
        private static Databas instans = null;
        private static object lockToken = new object();

        private static List<Utbildning> utbildningar = new List<Utbildning>();
        private static List<Schema> scheman = new List<Schema>();
        private static List<person> personer = new List<person>();
        public static Databas Instans
        {
            get
            {
                lock (lockToken)
                {
                    instans ??= new Databas();
                }
                return instans;
            }
        }



        public List<Schema> HämtaAllaScheman()
        {
            return new List<Schema>(scheman);
        }
        public List<Utbildning> HämtaAllaUtbildningar()
        {
            return new List<Utbildning>(utbildningar);
        }
        public List<person> HämtaAllaPersoner()
        {
            return new List<person>(personer);
        }
    }
}

}
}
