using System;

namespace ConsoleApplication {
    class AnasAmericana: Animal {
        public AnasAmericana(){
            this.name = "American Wigeon";
        }
        public AnasAmericana(string animalName){
            this.name = animalName;
        }
        public AnasAmericana(int length){
            this.length = length;
        }
        public AnasAmericana(string animalName, int length){
            this.name = animalName;
            this.length = length;
        }
        public override string foods(){
            return $"instead of {base.foods()}, it eats dirt";
        }
    }
}