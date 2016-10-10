using System;

namespace ConsoleApplication {
    class Animal: IAnimal {
        public string color {get; set;}
        public string name {get;set;}
        public int length {get; set;}
        public string call {get;set;}
        public string printDuck() {
            return $"Name:{this.name} Color: {this.color}";
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
    }
}