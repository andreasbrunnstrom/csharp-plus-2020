using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Animals
{
    public abstract class Animal
    {
        public int AgeInYears;

        public Animal(int ageInYears)
        {

        }

        public abstract void EatFood();

        //Konkret metoddefination vs abstrakt.
        public void Breed()
        {
            // This implementation does nothing.
        }
    }
}
