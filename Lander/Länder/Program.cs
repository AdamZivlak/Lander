namespace Länder
{
    internal class Program
    {
        public class Land
        {
            public string land, styrestyp, huvudstad, invånarantal;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Land sverige = new Land()
            {
                land = "Sverige",
                styrestyp = "monarki",
                huvudstad = "Stockholm",
                invånarantal = "10 512 820"
            };
            Land tyskland = new Land()
            {
                land = "Tyskland",
                styrestyp = "republik",
                huvudstad = "Berlin",
                invånarantal = "83 783 902"
            };
            Land san_marino = new Land()
            {
                land = "San Marino",
                styrestyp = "republik",
                huvudstad = "San Marino",
                invånarantal = "33 600"
            };
            //Console.WriteLine($"Land: {sverige.land}");
            //Console.WriteLine($"Huvudstad: {sverige.huvudstad}");
            //Console.WriteLine($"Styrestyp: {sverige.styrestyp}");
            //Console.WriteLine($"Invånarantal: {sverige.invånarantal} männsikor");
        }
    }
}