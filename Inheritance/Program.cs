using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE Create a class Animal
            // DONE give this class 4 members that all Animals have in common


            // DONE Create a class Bird
            // DONE give this class 4 members that are specific to Bird
            // DONE Set this class to inherit from your Animal Class

            // DONE Create a class Reptile
            // DONE give this class 4 members that are specific to Reptile
            // DONE Set this class to inherit from your Animal Class




            /*DONE Create an object of your Bird class
             *DONE give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */


            var newBird = new Birds();
            {
                newBird.FeatherColor = "Blue";
                newBird.WingLength = 22.45;
                newBird.CanFly = false;
                newBird.ChirpNoise = "tweet tweet";
            };


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var newReptile = new Reptiles();
            {
                newReptile.HasScales = true;
                newReptile.LegCount = 0;
                newReptile.IsPoisonous = true;
                newReptile.TailLength = 26.74;
            };


            var myAnimals = new Animals[] { newBird, newReptile };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Land, Air, or Sea?: {animal.LandAirSea}");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"Is Dangerous?: {animal.IsDangerous}");
                Console.WriteLine($"Weight?: {animal.Weight}");
                Console.WriteLine("");


            }




        }
    }
}
