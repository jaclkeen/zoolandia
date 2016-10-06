using System;

namespace ConsoleApplication {
    class Animal {
        public string name {get;set;}
        public int length {get; set;}
        public string call{get;set;}
        public static void sleep() {
            Console.WriteLine("Animal is now sleeping");
        }
    }
}