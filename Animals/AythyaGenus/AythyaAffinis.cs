using System;

namespace ConsoleApplication {
    class Affinis: Animal {
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
        public override string diveDepth(){
            return "Max dive: 8ft";
        }
    }
}