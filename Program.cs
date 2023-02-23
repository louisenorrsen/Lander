namespace Lander
{
    internal class Program
    {
        class Land
        {
            public string namn, styrestyp, huvudstad;
            public int invånartal;

            public void Print()
            {
                Console.WriteLine($"Land: {namn}\n    Styrestyp: {styrestyp}\n    Huvudstad: {huvudstad}\n    Invånartal: {invånartal}");
            }
        }
        static void Main(string[] args)
        {
            Land sverige = new Land()
            {
                namn = "Sverige",
                styrestyp = "Monarki",
                huvudstad = "Stockholm",
                invånartal = 10512820
            };
            Land tyskland = new Land()
            {
                namn = "Tyskland",
                styrestyp = "Republik",
                huvudstad = "Berlin",
                invånartal = 83783902
            };
            Land sanmarino = new Land()
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
                    huvudstad = "San Marino",
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

            for (int i = 0; i < länder.Length; i++)
            {
                if (länder[i].styrestyp == "Republik")
                {
                    Console.WriteLine($"Index: {i} | Land: {länder[i].namn}");
                }
            }
        }
    }
}