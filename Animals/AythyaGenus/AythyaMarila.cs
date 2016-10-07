using System;

namespace ConsoleApplication {
    class Marila: Aythya {
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
        public string swim(int speed){
            return $"The {this.name} is swimming {speed}mph";
        }
    }
}