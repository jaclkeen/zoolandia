using System;

namespace ConsoleApplication {
    class AnasClypeata: Animal {
        public AnasClypeata(){
            this.name = "Northern Shoveler";
        }
        public AnasClypeata(string animalName){
            this.name = animalName;
        }
        public AnasClypeata(int length){
            this.length = length;
        }
        public AnasClypeata(string animalName, int length) {
            this.name = animalName;
            this.length = length;
        }
        public override string foods(){
            return $"instead of {base.foods()}, it eats small bugs";
        }
    }
}