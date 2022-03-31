using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Phylum = "Chordata";
            Class = "Aves";
        }

        public int NumberOfHeartChambers { get; set; } = 4;
        public bool Beak { get; set; } = true;
        public string WingspanRange { get; set; }
        public bool CanFly { get; set;  }

        public void DisplayInformation(string birdName) //how to use just the object bird from main program
        {
            Console.WriteLine($"A {birdName} is of the Phylum {Phylum} and Class {Class} and has a wingspan range of {WingspanRange}.");
            Console.WriteLine((CanFly == true) ? ($"A {birdName} can fly!") : ($"A {birdName} can not fly."));
            Console.WriteLine((Beak == true) ? $"A {birdName} has a beak." : $"A {birdName} does not have a beak.");
            Console.WriteLine(IsWarmBlooded ? $"A {birdName} is warm blooded." : $"A {birdName} is cold blooded.");
            Console.WriteLine(LaysEggs ? $"A {birdName} lays eggs." : $"A {birdName} does not lay eggs.");
            
        }
    }
}
