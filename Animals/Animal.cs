using System;

namespace ConsoleApplication {
    class Animal {
        public string name {get;set;}
        public int length {get; set;}
        public string call {get;set;}
        public string sleep() {
            return "Animal is now sleeping";
        }
        public virtual string foods(){
            return "grass";
        }
    }
}