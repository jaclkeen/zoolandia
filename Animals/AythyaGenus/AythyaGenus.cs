using System;

namespace ConsoleApplication {
    class Aythya: Animal {
        public string genusName = "Aythya";
        public string genusMeaning = "sea-dwelling duck";
        public string genusAnimalType = "diving ducks";
        public string printDuck() {
            return $"Name:{base.name} GenusName:{this.genusName} GenusMeaning:{this.genusMeaning} ConsistsOf:{this.genusAnimalType} Call:{base.call} Foods:{base.foods()}";
        }
        public string swim(){
            int speed = 1;
            return $"This duck is swimming {speed}mph";
        }
    }
}