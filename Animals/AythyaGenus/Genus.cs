using System;

namespace ConsoleApplication {
    class Genus {
        public string genusName = "Aythya";
        public string genusMeaning = "sea-dwelling duck";
        public string genusAnimalType = "diving ducks";
        public string genusInformation(){
            return  $"GenusName:{this.genusName} GenusMeaning:{this.genusMeaning} ConsistsOf:{this.genusAnimalType}";
        }
    }
}