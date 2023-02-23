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
                Console.WriteLine($"    Styrestyp: {styrestyp}");
                Console.WriteLine($"    Huvudstad: {huvudstad}");
                Console.WriteLine($"    Invånare: {invånarantal} människor");
            }
        }
        public static void Main(string[] args)
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

            Land[] array = new Land[7] { sverige, tyskland, san_marino, 
                new Land() { land = "Danmark", styrestyp = "monarki", 
                    huvudstad = "Köpenhamn", invånarantal = "5 928 364"},
                new Land() { land = "Italien", styrestyp = "republik",
                    huvudstad = "Rom", invånarantal = "58 853 482"}, 
                new Land() { land = "Tjeckien", styrestyp = "republik",
                    huvudstad = "Prag", invånarantal = "10 551 219"}, 
                new Land() { land = "Rumänien", styrestyp = "republik",
                    huvudstad = "Bukarest", invånarantal = "19 760 314"} };
            
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] !=  null)
                    array[i].print();
            }
        }
    }
}