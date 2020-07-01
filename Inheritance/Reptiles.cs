using System;
namespace Inheritance
{
    public class Reptiles : Animals
    {
        public Reptiles()
        {
            LandAirSea = "Land and Sea";
            Age = 10000;
            IsDangerous = "Mostly";
            Weight = 134.56;

        }

        public bool HasScales { get; set; }
        public int LegCount { get; set; }
        public bool IsPoisonous { get; set; }
        public double TailLength { get; set; }








    }
}
