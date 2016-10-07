using System;

namespace ConsoleApplication {
    class Anas: Animal {
        public string genusName = "Anas";
        public string genusMeaning = "duck";
        public string genusAnimalType = "dabbling ducks";
        public string printDuck() {
            return $"Name:{base.name} GenusName:{this.genusName} GenusMeaning:{this.genusMeaning} ConsistsOf:{this.genusAnimalType} Call:{base.call} Foods:{base.foods()} DiveDepth: {this.diveDepth()}";
        }
        public virtual string diveDepth(){
            return "low";
        }
    }
}