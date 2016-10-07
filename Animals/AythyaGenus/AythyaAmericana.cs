using System;

namespace ConsoleApplication {
    class Americana: Aythya {
        public string color = "red";
        public Americana(){
            this.name = "Redhead";
        }
        public Americana(string animalName){
            this.name = animalName;
        }
        public Americana(int length){
            this.length = length;
        }
        public Americana(string animalName, int length){
            this.name = animalName;
            this.length = length;
        }
        public string swim(int speed, string destination){
            return $"This duck is swimming {speed}mph, and is going to {destination}";
        }
    }
}