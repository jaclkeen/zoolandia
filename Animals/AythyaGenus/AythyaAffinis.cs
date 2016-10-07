using System;

namespace ConsoleApplication {
    class Affinis: Aythya {
        public string color = "grey and brown";
        public Affinis(){
            this.name = "Lesser Scaup";
        }
        public Affinis(string animalName){
            this.name = animalName;
        }
        public Affinis(int length){
            this.length = length;
        }
        public Affinis(string animalName, int length){
            this.name = animalName;
            this.length = length;
        }
        public string swim(int speed){
            return $"This duck is swimming {speed}mph";
        }
    }
}