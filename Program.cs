using System;

namespace ConsoleApplication{
    public class Program{
        public static void Main(string[] args){

            AnasAcuta northernPintail = new AnasAcuta(){
                name = "Northern Pintail",
                length = 76,
                call = "proop-proop",
                color = "purple"
            };
            Console.WriteLine($"{northernPintail.printDuck()} {northernPintail.genus.genusInformation()} {northernPintail.diveDepth()}");

            AnasAmerican americanWigeon = new AnasAmerican("American Wigeon", 23){
                call = "whoee-whoe-whoe",
                color = "orange"
            };
            Console.WriteLine($"{americanWigeon.printDuck()} {americanWigeon.genus.genusInformation()} {americanWigeon.diveDepth()}");

            AnasClypeata northernShovler = new AnasClypeata("Northern Shovler"){
                length = 43,
                call = "eeeekk",
                color = "blue"
            };
            Console.WriteLine($"{northernShovler.printDuck()} {northernShovler.genus.genusInformation()} {northernShovler.diveDepth()}");

            Affinis lesserScaup = new Affinis(){
                color = "pink"
            };
            Console.WriteLine($"{lesserScaup.printDuck()} {lesserScaup.genus.genusInformation()} {lesserScaup.diveDepth()}");

            Americana redHead = new Americana(){
                color = "brown"
            };
            Console.WriteLine($"{redHead.printDuck()} {redHead.genus.genusInformation()} {redHead.diveDepth()}");

            Marila greaterScaup = new Marila(){
                color = "white"
            };
            Console.WriteLine($"{greaterScaup.printDuck()} {greaterScaup.genus.genusInformation()} {greaterScaup.diveDepth()}");
            Console.WriteLine(greaterScaup.swim(5));
            Console.WriteLine(greaterScaup.sleep());
        }
    }
}
