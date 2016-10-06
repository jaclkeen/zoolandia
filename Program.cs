using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AixSponsa woodDuck = new AixSponsa("Wood Duck", 54){
                call = "jeeeeee"
            };

            AnasBahamensis whiteCheekedPintail = new AnasBahamensis(50){
                name = "White Cheeked Pintail",
                call = "heeeeeyyyy"
            };

            AnasAcuta northernPintail = new AnasAcuta(){
                name = "northernPintail",
                length = 76,
                call = "proop-proop"
            };

            AnasAmerican americanWigeon = new AnasAmerican("American Wigeon", 23){
                call = "whoee-whoe-whoe"
            };

            Console.WriteLine($"There is a {woodDuck.name}, its length is {woodDuck.length}, its call is {woodDuck.call}, and {woodDuck.foods()}");
            Console.WriteLine($"There is a {whiteCheekedPintail.name}, its length is {whiteCheekedPintail.length}, its call is {whiteCheekedPintail.call}, and {whiteCheekedPintail.foods()}");
            Console.WriteLine($"There is a {northernPintail.name}, its length is {northernPintail.length}, its call is {northernPintail.call}, and {northernPintail.foods()}");
            Console.WriteLine($"There is a {americanWigeon.name}, its length is {americanWigeon.length}, its call is {americanWigeon.call}, and {americanWigeon.foods()}");            
        }
    }
}
