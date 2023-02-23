using System.Linq;
namespace Lander
{
    internal class Program
    {
        class Land
        {
            public string namn = string.Empty, styrestyp = string.Empty, huvudstad = string.Empty;
            public int invånartal;

            public void Print()
            {
                Console.WriteLine($"Land: {namn}\n    Styrestyp: {styrestyp}\n    Huvudstad: {huvudstad}\n    Invånartal: {invånartal}");
            }
        }
        static void Main(string[] args)
        {
            Land sverige = new()
            {
                namn = "Sverige",
                styrestyp = "Monarki",
                huvudstad = "Stockholm",
                invånartal = 10512820
            };
            Land tyskland = new()
            {
                namn = "Tyskland",
                styrestyp = "Republik",
                huvudstad = "Berlin",
                invånartal = 83783902
            };
            Land sanmarino = new()
            {
                namn = "San Marino",
                styrestyp = "Republik",
                huvudstad = "San Marino",
                invånartal = 33600
            };

            Land[] länder = new Land[7]
            { sverige, tyskland, sanmarino,
                new Land()
                {
                    namn = "Danmark",
                    styrestyp = "Monarki",
                    huvudstad = "Köpenhamn",
                    invånartal = 5928364
                },
                new Land()
                {
                    namn = "Italien",
                    styrestyp = "Republik",
                    huvudstad = "Rom",
                    invånartal = 58853482
                },
                new Land()
                {
                    namn = "Tjekien",
                    styrestyp = "Republik",
                    huvudstad = "Prag",
                    invånartal = 10551219
                },
                new Land()
                {
                    namn = "Rumänien",
                    styrestyp = "Republik",
                    huvudstad = "Bukarest",
                    invånartal = 19760314
                }
            };

            //foreach (Land land in länder)
            //{
            //    land.Print();
            //}

            //for (int i = 0; i < länder.Length; i++)
            //{
            //    if (länder[i].styrestyp == "Republik")
            //    {                    
            //        Console.WriteLine($"Index: {i} | Land: {länder[i].namn}");
            //    }
            //}
            //int lägsta = länder.Where(x => x.styrestyp == "Republik").Min(x=>x.invånartal);
            //int högsta = länder.Where(x => x.styrestyp == "Republik").Max(x=>x.invånartal);
            int lägsta = länder.Min(x => x.invånartal);
            int högsta = länder.Max(x => x.invånartal);
            for (int i = 0; i < länder.Length; i++)
            {
                if (länder[i].styrestyp == "Republik" && länder[i].invånartal == lägsta)
                {
                    Console.WriteLine($"=== Republik med minsta invånarantal ===");
                    länder[i].Print();
                }
                if (länder[i].styrestyp == "Republik" && länder[i].invånartal == högsta)
                {
                    Console.WriteLine($"=== Republik med största invånarantal ===");
                    länder[i].Print();
                }
            }
        }
    }
}