using System;

namespace ConsoleApplication{
    public class Program{
        public static void Main(string[] args){

            AnasAcuta northernPintail = new AnasAcuta(){
                name = "Northern Pintail",
                length = 76,
                call = "proop-proop",
                color = "purple",
                genus = new Anas()
            };
            Console.WriteLine($"{northernPintail.printDuck()} {northernPintail.genus.genusInformation()} {northernPintail.diveDepth()} {northernPintail.foods()}");

            AnasAmericana americanWigeon = new AnasAmericana("American Wigeon", 23){
                call = "whoee-whoe-whoe",
                color = "orange",
                genus = new Anas()
            };
            Console.WriteLine($"{americanWigeon.printDuck()} {americanWigeon.genus.genusInformation()} {americanWigeon.diveDepth()} {americanWigeon.foods()}");

            AnasClypeata northernShovler = new AnasClypeata("Northern Shovler"){
                length = 43,
                call = "eeeekk",
                color = "blue",
                genus = new Anas()
            };
            Console.WriteLine($"{northernShovler.printDuck()} {northernShovler.genus.genusInformation()} {northernShovler.diveDepth()} {northernShovler.foods()}");

            Affinis lesserScaup = new Affinis("Lesser Scaup"){
                color = "pink",
                genus = new Aythya()
            };
            Console.WriteLine($"{lesserScaup.printDuck()} {lesserScaup.genus.genusInformation()} {lesserScaup.diveDepth()} {lesserScaup.foods()}");

            Americana redHead = new Americana(){
                name = "Red Head",
                color = "brown",
                genus = new Aythya()
            };
            Console.WriteLine($"{redHead.printDuck()} {redHead.genus.genusInformation()} {redHead.diveDepth()} {redHead.foods()}");

            Marila greaterScaup = new Marila(){
                color = "white",
                genus = new Aythya()
            };
            Console.WriteLine($"{greaterScaup.printDuck()} {greaterScaup.genus.genusInformation()} {greaterScaup.diveDepth()} {greaterScaup.foods()}");
            Console.WriteLine(greaterScaup.swim(5));
            Console.WriteLine(redHead.sleep());
        }
    }
}
