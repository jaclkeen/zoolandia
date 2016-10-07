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
            Console.WriteLine(northernPintail.printDuck());

            AnasAmerican americanWigeon = new AnasAmerican("American Wigeon", 23){
                call = "whoee-whoe-whoe",
                color = "orange"
            };
            Console.WriteLine(americanWigeon.printDuck());

            AnasClypeata northernShovler = new AnasClypeata("Northern Shovler"){
                length = 43,
                call = "eeeekk",
                color = "blue"
            };
            Console.WriteLine(northernShovler.printDuck());

            Affinis lesserScaup = new Affinis(){
                color = "pink"
            };
            Console.WriteLine(lesserScaup.printDuck());

            Americana redHead = new Americana(){
                color = "brown"
            };
            Console.WriteLine(redHead.printDuck());

            Marila greaterScaup = new Marila(){
                color = "white"
            };
            Console.WriteLine(greaterScaup.printDuck());
            Console.WriteLine(greaterScaup.swim(5));
        }
    }
}
