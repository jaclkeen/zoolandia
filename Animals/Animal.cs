using System;

namespace ConsoleApplication {
    class Animal: IAnimal {
        public Animal(){
            this.name = "ducky duck";
        }
        public Animal(string animalName){
            this.name = animalName;
        }
        public Animal(int length){
            this.length = length;
        }
        public Animal(string animalName, int length){
            this.name = animalName;
            this.length = length;
        }
        public Genus genus {get;set;}
        public string color {get; set;}
        public string name {get;set;}
        public int length {get; set;}
        public string call {get;set;}
        public string printDuck() {
            return $"Name: {this.name} Color: {this.color}";
        }
        public string sleep() {
            return $"{this.name} is now sleeping";
        }
        public virtual string foods(){
            return "grass";
        }
        public virtual string diveDepth(){
            return "This duck doesn't dive!";
        }
        public string swim(int speed){
            return $"This duck is swimming {speed}mph";
        }
    }
}