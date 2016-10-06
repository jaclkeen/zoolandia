using System;

namespace ConsoleApplication {
    class AnasAmerican: Animal {
        public AnasAmerican(string animalName){
            this.name = animalName;
        }
        public override string foods(){
            return $"Instead of {base.foods()}, it eats dirt";
        }
    }
}