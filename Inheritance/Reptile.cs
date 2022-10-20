using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        
        public string ColorOfScales { get; set; }
        
        public bool  CanSwim { get; set; }

        public string IsitNoctornal { get; set; }
        public void TellMe()
        {
            if (NumbersofLegs == 0)
            {
                Console.WriteLine($"This is a {Howold} year old Reptile with {ColorOfScales} scales.  It can swim amd weighs {weight} and {HowLong}. It has no legs so it must be a snake.  ");
            }
            else if (CanSwim == true)
            {
                Console.WriteLine($"This is a {Howold} year old Reptile with {ColorOfScales} scales.  It can swim amd weighs {weight} and {HowLong}. It has {NumbersofLegs}. And they are {IsitNoctornal} Nocturnal. Might be a croc or gator or turtle. ");
            }
            else
            {
                Console.WriteLine($"This is a {Howold} year old Reptile with {ColorOfScales} scales.  It can not swim amd weighs {weight} and {HowLong}. It has {NumbersofLegs}. Most likely a lizard but to many reptiles to tell honestly ");
            }




        }
    }
}
