using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SkapaSchema.Presentationslager.Menyer.SkapaSchema;

namespace SkapaSchema.Presentationslager.Menyer
{
    internal class SkapaSchema
    {
        public class Undermeny1 : Meny
        {
            public override void VisaMeny()
            {
                Console.Clear();
                Console.WriteLine("==== Undermeny 1 ====");
                Console.WriteLine("1. Gå till Undermeny 1.1");
                Console.WriteLine("2. Gå tillbaka till Huvudmeny");
                Console.Write("Välj ett alternativ: ");

                int val = int.Parse(Console.ReadLine());

                switch (val)
                {
                    case 1:
                        Undermeny11 undermeny11 = new Undermeny11();
                        undermeny11.VisaMeny();
                        break;
                    case 2:
                        // Återvänd till huvudmenyn genom att helt enkelt avsluta metoden
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        VisaMeny(); // Visa menyn igen vid ogiltigt val
                        break;
                }
            }
        }

    }
}
