using System;

namespace ConsoleApplication {
    class Aythya {
        public string genusName = "Aythya";
        public string genusMeaning = "sea-dwelling duck";
        public string genusAnimalType = "diving ducks";
        public string swim(){
            return $"This duck is swimming 1 mph";
        }
        public string genusInformation(){
            return  $"GenusName:{this.genusName} GenusMeaning:{this.genusMeaning} ConsistsOf:{this.genusAnimalType}";
        }
    }
}