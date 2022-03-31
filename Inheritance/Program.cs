using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var penguin = new Bird();
            penguin.LaysEggs = true;
            penguin.Beak = true;
            penguin.WingspanRange = "76 to 89 cm";
            penguin.CanFly = false;
            penguin.IsWarmBlooded = true;
            penguin.DisplayInformation("penguin");

            Console.WriteLine("\n--------------------\n");

            var rattlesnake = new Reptile();
            rattlesnake.IsWarmBlooded = false;
            rattlesnake.LaysEggs = false;
            rattlesnake.NumberOfLungs = 2;
            rattlesnake.HasVenom = true;
            rattlesnake.LengthRange = "0.5 to 2 meters";
            rattlesnake.DisplayInformation("rattlesnake");

    }
    }
}
