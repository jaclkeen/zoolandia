using System;

namespace ConsoleApplication {
    class AnasBahamensis: Animal {
        public AnasBahamensis(){
            this.name = "White Cheeked Pintail";
        }
        public AnasBahamensis(string animalName){
            this.name = animalName;
        }
        public AnasBahamensis(int length){
            this.length = length;
        }
        public AnasBahamensis(string animalName, int length){
            this.name = animalName;
            this.length = length;
        }
        public override string foods(){
            return $"instead of {base.foods()}, it eats other fish!";
        }
    }
}