using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal1 = new Bird() {weight= 35 , HowLong = "1 foot 6 inches", Howold = 3 , NumbersofLegs = 2, WingSpan = "3 feet", CanSwim = false, FeatherColor = "black", WhatItEats = "Fruit"};

            animal1.gimmeInfo();
            Console.WriteLine();

            var animal2 = new Bird() { weight = 20, Howold = 2, HowLong = "2 feet", NumbersofLegs = 2, WingSpan = "2 feet", CanSwim = true, FeatherColor = "blackish blue", WhatItEats = "fish" };

            animal2.gimmeInfo();
            Console.WriteLine();
            
            
            var animal3 = new Reptile() { weight =75, HowLong = "5 feet", CanSwim = true, NumbersofLegs = 4, ColorOfScales = "green", Howold = 30, IsitNoctornal = "Sometimes" };

            animal3.TellMe();
            Console.WriteLine();

            var animal4 = new Reptile() { weight = 10, HowLong = "8 feet", CanSwim = false, NumbersofLegs = 0, ColorOfScales = "brown", Howold = 10 , IsitNoctornal = "is not" };

            animal4.TellMe();
            Console.WriteLine();

            var animal5 = new Reptile() { weight = 10, HowLong = "3 feet", CanSwim = false, NumbersofLegs = 2, ColorOfScales = "green", Howold = 10, IsitNoctornal = "sometimes" };

            animal5.TellMe();
            Console.WriteLine();





            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




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
}
