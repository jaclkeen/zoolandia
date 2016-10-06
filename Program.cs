using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AixSponsa woodDuck = new AixSponsa("Wood Duck"){
                length = 54,
                call = "jeeeeee"
            };

            AnasBahamensis whiteCheekedPintail = new AnasBahamensis("White Cheeked Pintail"){
                length = 50,
                call = "heeeeeyyyy"
            };

            AnasAcuta northernPintail = new AnasAcuta("Northern Pintail"){
                length = 76,
                call = "proop-proop"
            };

            AnasAmerican americanWigeon = new AnasAmerican("American Wigeon"){
                length = 23,
                call = "whoee-whoe-whoe"
            };

            Console.WriteLine($"There is a {woodDuck.name}, its length is {woodDuck.length}, and its call is {woodDuck.call}, {woodDuck.foods()}");
            Console.WriteLine($"There is a {whiteCheekedPintail.name}, its length is {whiteCheekedPintail.length}, and its call is {whiteCheekedPintail.call}, {whiteCheekedPintail.foods()}");
            Console.WriteLine($"There is a {northernPintail.name}, its length is {northernPintail.length}, and its call is {northernPintail.call}, {northernPintail.foods()}");
            Console.WriteLine($"There is a {americanWigeon.name}, its length is {americanWigeon.length}, and its call is {americanWigeon.call}, {americanWigeon.foods()}");            
        }
    }
}
