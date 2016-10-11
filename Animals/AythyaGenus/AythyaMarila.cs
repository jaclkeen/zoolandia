using System;

namespace ConsoleApplication {
    class Marila: Animal {
        public Marila(){
            this.name = "Greater Scaup";
        }
        public Marila(string animalName){
            this.name = animalName;
        }
        public Marila(int length){
            this.length = length;
        }
        public Marila(string animalName, int length){
            this.name = animalName;
            this.length = length;
        }
        public override string diveDepth(){
            return "Max dive: 35ft";
        }
    }
}