using System;

namespace ConsoleApplication {
    class Anas {
        public string genusName = "Anas";
        public string genusMeaning = "duck";
        public string genusAnimalType = "dabbling ducks";
        public string genusInformation(){
            return  $"GenusName:{this.genusName} GenusMeaning:{this.genusMeaning} ConsistsOf:{this.genusAnimalType}";
        }
    }
}