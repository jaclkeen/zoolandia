using System;

namespace ConsoleApplication {
    class AnasAmerican: Anas {
        public AnasAmerican(){
            this.name = "American Wigeon";
        }
        public AnasAmerican(string animalName){
            this.name = animalName;
        }
        public AnasAmerican(int length){
            this.length = length;
        }
        public AnasAmerican(string animalName, int length){
            this.name = animalName;
            this.length = length;
        }
        public override string foods(){
            return $"instead of {base.foods()}, it eats dirt";
        }
         public override string diveDepth(){
            return "deeepppp";
        }
    }
}