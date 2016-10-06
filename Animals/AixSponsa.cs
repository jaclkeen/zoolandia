using System;

namespace ConsoleApplication {
    class AixSponsa: Animal {
        public AixSponsa(string animalName){
            this.name = animalName;
        }
        public override string foods(){
            return $"Instead of {base.foods()}, it eats Berries";
        }
    }
}