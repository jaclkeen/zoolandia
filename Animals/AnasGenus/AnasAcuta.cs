using System;

namespace ConsoleApplication {
    class AnasAcuta: Animal {
        public Anas genus = new Anas();
        public AnasAcuta(){
            this.name = "Northern Pintail";
        }
        public AnasAcuta(string animalName){
            this.name = animalName;
        }
        public AnasAcuta(int length){
            this.length = length;
        }
        public AnasAcuta(string animalName, int length){
            this.name = animalName;
            this.length = length;
        }
        public override string diveDepth(){
            return "Max dive: 2ft";
        }
        public override string foods(){
            return $"instead of {base.foods()}, it eats PEOPLE!";
        }
    }
}