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

        public int NumberOfLungs;
        public bool HasBackbone = true;
        public bool HasScales = true;
        public bool HasVenom;
        public string LengthRange;

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