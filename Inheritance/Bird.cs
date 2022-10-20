using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public string WingSpan { get; set; }
        public String FeatherColor { get; set; }

        public bool CanSwim { get; set; }

        public string WhatItEats { get; set; }






        public void gimmeInfo()
        {
            if (CanSwim == true)
            {
                Console.WriteLine($"This is a {Howold} year old Bird with q {WingSpan} wingspan. This bird is one of the few that can swim amd weighs {weight} and {HowLong}. Like most birds it has {NumbersofLegs} legs. It enjoys eating {WhatItEats}. What is it a Penguin? ");

            }
            else
            {
                Console.WriteLine($"This is a {Howold} year old Bird with q {WingSpan} wingspan. Like most birds this one can not swim amd weighs {weight} and {HowLong}. Like most birds it has {NumbersofLegs} legs. It enjoys eating {WhatItEats}. With so many birds im not sure which one this is ");
            }
        }
    }
}
