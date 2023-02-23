using System.Runtime.InteropServices;

namespace Länder
{
    internal class Program
    {
        public class Land
        {
            public string land, styrestyp, huvudstad, invånarantal;

            public void print()
            {
                Console.WriteLine($"Land: {land}");
            }
        }
        static void Main(string[] args)
        {
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
            sverige.print();
            tyskland.print();
            san_marino.print();
            Console.WriteLine("--------------------------");

            string[] array = new string[7];
            array[0] = sverige.land;
            array[1] = tyskland.land;
            array[2] = san_marino.land;
            array[3] = "Danmark";
            array[4] = sverige.land;
            array[5] = sverige.land;
            array[6] = sverige.land;
            foreach(string a in array)
            {
                Console.WriteLine(a);
            }
        }
    }
}