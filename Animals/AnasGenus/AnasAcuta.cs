namespace ConsoleApplication {
    class AnasAcuta: Animal {
        public override string diveDepth(){
            return "Max dive: 2ft";
        }
        public override string foods(){
            return $"instead of {base.foods()}, it eats PEOPLE!";
        }
    }
}