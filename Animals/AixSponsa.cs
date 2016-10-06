using System;

namespace ConsoleApplication {
    class AixSponsa: Animal {
        public AixSponsa(){
            this.name = "Wood Duck";
        }
        public AixSponsa(string animalName){
            this.name = animalName;
        }
        public AixSponsa(int length){
            this.length = length;
        }
        public AixSponsa(string animalName, int length){
            this.name = animalName;
            this.length = length;
        }
        public override string foods(){
            return $"instead of {base.foods()}, it eats berries";
        }
    }
}