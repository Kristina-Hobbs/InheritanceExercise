using System;
namespace Inheritance
{
    public class Reptile : Animal 
    {
        public bool HasLegs { get; set; }

        public bool HasScales { get; set; }

        public string Environment { get; set; }

        public string Defense { get; set; }


        public Reptile()
        {

        }

        public Reptile(bool hasHorns, int numberOflegs, int age, string name, bool hasLegs, bool hasScales, string environment, string defense)
        {
            HasHorns = hasHorns;
            NumberOfLegs = numberOflegs;
            Age = age;
            Name = name;
            HasLegs = hasLegs;
            HasScales = HasScales;
            Environment = environment;
            Defense = defense;
        }

        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class
    }
}

