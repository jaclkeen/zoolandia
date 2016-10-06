using System;

namespace ConsoleApplication {
    class AnasAcuta: Animal {
        public AnasAcuta(string animalName){
            this.name = animalName;
        }
        public override string foods(){
            return $"Instead of {base.foods()}, it eats PEOPLE!";
        }
    }
}