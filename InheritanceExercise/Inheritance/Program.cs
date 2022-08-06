using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            Birds polly = new Birds()
            {
                HasHorns = false,
                NumberOfLegs = 2,
                Age = 10,
                Name = "Polly",
                WhatColorIsTheBird = "red",
                CanItFly = true,
                DoHumansEatTheirEggs = false,
                WhatKindOfBirdSeedToGiveIt = "tropical",
            };

            Console.WriteLine($"{polly.Name} is {polly.Age} years old. Their feathers are {polly.WhatColorIsTheBird} " +
                $"and they eat {polly.WhatKindOfBirdSeedToGiveIt} bird seed and has {polly.NumberOfLegs} legs.");
            Console.WriteLine($"Does {polly.Name} have horns, fly, and do we eat their eggs?" +
                $"{polly.HasHorns}, {polly.CanItFly}, and {polly.DoHumansEatTheirEggs}.");
            

            Reptile chompy = new Reptile()
            {
                HasHorns = false,
                NumberOfLegs = 4,
                Age = 124,
                Name = "Chompy",
                HasLegs = true,
                HasScales = true,
                Environment = "swamplands",
                Defense = "teeth",
            };

            Console.WriteLine($"{chompy.Name} is {chompy.Age} years old, has {chompy.NumberOfLegs} legs, lives in the {chompy.Environment}" +
                $"and defends himself with his {chompy.Defense}");
            Console.WriteLine($"Does {chompy.Name} have horns, legs, and scales? {chompy.HasHorns}, {chompy.HasLegs}, and {chompy.HasScales}");
    }


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }

