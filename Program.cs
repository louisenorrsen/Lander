namespace Lander
{
    internal class Program
    {
        class Land
        {
            public string namn, styrestyp, huvudstad;
            public int invånartal;
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
        }
    }
}