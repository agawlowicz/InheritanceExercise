using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsWarmBlooded = false;
            Phylum = "Chordata";
            Class = "Reptilia";
        }

        public int NumberOfLungs { get; set; }
        public bool HasBackbone { get; set; } = true;
        public bool HasScales { get; set; } = true;
        public bool HasVenom { get; set; }
        public string LengthRange { get; set; }

        public void DisplayInformation(string name)
        {
            Console.WriteLine($"A {name} is of the phylum {Phylum} and class {Class}.");
            Console.WriteLine(IsWarmBlooded ? $"A {name} is warm blooded." : $"A {name} is cold blooded.");
            Console.WriteLine(HasBackbone ? $"A {name} is a vertebrate." : $"A {name} is not a vertebrate.");
            Console.WriteLine(HasScales ? $"A {name} has scales." : $"A {name} does not have scales.");
            Console.WriteLine(HasVenom ? $"A {name} is venomous." : $"A {name} is not venomous.");
            Console.WriteLine($"A {name} has {NumberOfLungs} lungs and an average length of {LengthRange}.");
        }

    }
}