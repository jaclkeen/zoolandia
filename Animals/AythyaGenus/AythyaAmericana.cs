using System;

namespace ConsoleApplication {
    class Americana: Animal {
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
        public override string diveDepth(){
            return "Max dive: 25ft";
        }
    }
}