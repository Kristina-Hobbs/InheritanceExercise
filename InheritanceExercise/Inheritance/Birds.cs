using System;
namespace Inheritance
{
    public class Birds : Animal 
    {
        public string WhatColorIsTheBird { get; set; }

        public bool CanItFly { get; set; }

        public bool DoHumansEatTheirEggs { get; set; }

        public string WhatKindOfBirdSeedToGiveIt { get; set; }


        public Birds()
        {

        }


        public Birds(bool hasHorns, int numberOflegs, int age, string name, string whatColoristhebird, bool canItfly, bool doHumanseaattheireggs, string whatKindofbirdseedtogiveit)
        {
            HasHorns = hasHorns;
            NumberOfLegs = numberOflegs;
            Age = age;
            Name = name;
            WhatColorIsTheBird = whatColoristhebird;
            CanItFly = canItfly;
            DoHumansEatTheirEggs = doHumanseaattheireggs;
            WhatKindOfBirdSeedToGiveIt = whatKindofbirdseedtogiveit;
        }
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class
    }


}

