using System.Runtime.InteropServices;

namespace Länder
{
    internal class Program
    {
        public class Land
        {

            public string land, styrestyp, huvudstad;
            public int invånarantal;

            public void print()
            {
                Console.WriteLine($"Land: {land}"); 
                Console.WriteLine($"    Huvudstad: {huvudstad}");
                Console.WriteLine($"    Styrestyp: {styrestyp}");
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
                invånarantal = 10512820
            };
            Land tyskland = new Land()
            {
                land = "Tyskland",
                styrestyp = "republik",
                huvudstad = "Berlin",
                invånarantal = 83783902
            };
            Land san_marino = new Land()
            {
                land = "San Marino",
                styrestyp = "republik",
                huvudstad = "San Marino",
                invånarantal = 33600
            };
            //sverige.print();
            //tyskland.print();
            //san_marino.print();
            Console.WriteLine("---------------------------------------------");

            Land[] länder = new Land[7] 
            { 
                sverige,
                tyskland, 
                san_marino, 
                new Land() 
                { 
                    land = "Danmark", 
                    styrestyp = "monarki", 
                    huvudstad = "Köpenhamn", 
                    invånarantal = 5928364},
                new Land() 
                { 
                    land = "Italien", 
                    styrestyp = "republik",
                    huvudstad = "Rom", 
                    invånarantal = 58853482}, 
                new Land() 
                { 
                    land = "Tjeckien", 
                    styrestyp = "republik",
                    huvudstad = "Prag", 
                    invånarantal = 10551219}, 
                new Land() 
                { 
                    land = "Rumänien", 
                    styrestyp = "republik",
                    huvudstad = "Bukarest", 
                    invånarantal = 19760314} };
            
            //for(int i = 0; i < länder.Length; i++)
            //{
            //    if (länder[i] !=  null)
            //        länder[i].print();
            //}
            Console.WriteLine("----------------------------------------------");
            foreach(Land  L  in länder)
            {
                L.print();
            }
            Console.WriteLine("==== Lista alla republiker ====");
            for (int i = 0; i < länder.Length; i++)
            {
                if (länder[i].styrestyp == "republik")
                    Console.WriteLine($"{i}: {länder[i].land}");
            }
                
        }
    }
}