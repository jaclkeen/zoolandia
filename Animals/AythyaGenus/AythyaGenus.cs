using System;

namespace ConsoleApplication {
    class Aythya: Animal {
        public string genusName = "Aythya";
        public string genusMeaning = "sea-dwelling duck";
        public string genusAnimalType = "diving ducks";
        public string printDuck() {
            return $"Name:{base.name} GenusName:{this.genusName} GenusMeaning:{this.genusMeaning} ConsistsOf:{this.genusAnimalType} Foods:{base.foods()} Color: {this.color}";
        }
        public string swim(){
            return $"This duck is swimming 1 mph";
        }
    }
}