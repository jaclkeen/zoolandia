using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AixSponsa woodDuck = new AixSponsa{
                name = "Wood Duck",
                length = 54,
                call = "jeeeeee"
            };

            AnasBahamensis whiteCheekedPintail = new AnasBahamensis{
                name = "White Cheeked Pintail",
                length = 50,
                call = "heeeeeyyyy"
            };

            AnasAcuta northernPintail = new AnasAcuta{
                name = "Northern Pintail",
                length = 76,
                call = "proop-proop"
            };

            AnasAmerican americanWigeon = new AnasAmerican{
                name = "American Wigeon",
                length = 23,
                call = "whoee-whoe-whoe"
            };

            Console.WriteLine($"There is a {woodDuck.name}, its length is {woodDuck.length}, and its call is {woodDuck.call}");
            Console.WriteLine($"There is a {whiteCheekedPintail.name}, its length is {whiteCheekedPintail.length}, and its call is {whiteCheekedPintail.call}");
            Console.WriteLine($"There is a {northernPintail.name}, its length is {northernPintail.length}, and its call is {northernPintail.call}");
            Console.WriteLine($"There is a {americanWigeon.name}, its length is {americanWigeon.length}, and its call is {americanWigeon.call}");            
        }
    }
}
