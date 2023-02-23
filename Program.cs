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
                styrestyp = "monarki",
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

            sverige.Print();
            tyskland.Print();
            sanmarino.Print();
        }
    }
}