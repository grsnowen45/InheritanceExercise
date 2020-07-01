using System;
namespace Inheritance
{
    public class Birds : Animals
    {
        public Birds()
        {
            LandAirSea = "Air";
            Age = 100;
            IsDangerous = "sometimes";
            Weight = 12.56;

        }





        public string FeatherColor { get; set; }
        public double WingLength { get; set; }
        public bool CanFly { get; set; }
        public string ChirpNoise { get; set; }







    }

}
