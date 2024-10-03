namespace SkapaSchema.Presentationslager.Menyer
{
    public class LoggaInMeny : Meny
    {
        public override void VisaMeny(MenyKontext kontext)
        {
            bool Start = true;

            while (Start)
            {
                Console.Clear();
                Console.WriteLine("==== Huvudmeny ====");
                Console.WriteLine("1. Gå till Undermeny 1");
                Console.WriteLine("2. Gå till Undermeny 2");
                Console.WriteLine("3. Avsluta");
                Console.Write("Välj ett alternativ: ");

                int val = int.Parse(Console.ReadLine());

                switch (val)
                {
                    case 1:
                        SkapaSchema SkapaSchema = new SkapaSchema();
                        SkapaSchema.VisaMeny();
                        break;
                    case 2:
                        VisaSchema VisaSchema = new VisaSchema();
                        VisaSchema.VisaMeny();
                        break;
                    case 3:
                        körProgrammet = false;
                        Console.WriteLine("Programmet avslutas...");
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
        }
    }

    }