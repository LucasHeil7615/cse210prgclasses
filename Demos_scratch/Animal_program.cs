using System;

class Program
{
    static void Main(string[] args){
        BaldEagle Joey = new BaldEagle("Joey", "Screee!");
        BaldEagle Dragon = new BaldEagle("Dragon", "A10 Warthog (Fireball)");

        Joey.MakeSound();
        Dragon.MakeSound();
    }
}