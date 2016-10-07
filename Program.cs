using System;

namespace ConsoleApplication{
    public class Program{
        public static void Main(string[] args){

            AnasAcuta northernPintail = new AnasAcuta(){
                name = "Northern Pintail",
                length = 76,
                call = "proop-proop",
            };
            Console.WriteLine(northernPintail.printDuck());

            AnasAmerican americanWigeon = new AnasAmerican("American Wigeon", 23){
                call = "whoee-whoe-whoe"
            };
            Console.WriteLine(americanWigeon.printDuck());

            AnasClypeata northernShovler = new AnasClypeata("Northern Shovler"){
                length = 43,
                call = "eeeekk"
            };
            Console.WriteLine(northernShovler.printDuck());

            Affinis lesserScaup = new Affinis();
            Console.WriteLine(lesserScaup.printDuck());

            Americana redHead = new Americana();
            Console.WriteLine(redHead.printDuck());

            Marila greaterScaup = new Marila();
            Console.WriteLine(greaterScaup.printDuck());
            Console.WriteLine(greaterScaup.swim(5));
        }
    }
}
