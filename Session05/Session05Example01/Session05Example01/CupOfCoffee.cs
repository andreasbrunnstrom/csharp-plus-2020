using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Example01
{
    class CupOfCoffee
    {
        //Statiskt fält som är delat med hela klassen.
        public static string DefaultBeanType = "Blue Java";
        public static string[] BeanTypes;

        public string BeanType;
        public bool Instant;
        public bool Milk;
        public byte SugarCubes;
        public string Description;

        private string _id;

        //Konstruktor
        //Identisk med classnamn
        static CupOfCoffee()
        {
            BeanTypes = new []
            {
                "Arabica",
                "Blue Java",
                "Blue mountain",
                "Arusha"
            };
        }

        //Konstruktor
        //Identisk med classnamn
        public CupOfCoffee(bool milk, byte sugarCubes)
        {
            SugarCubes = sugarCubes;
            Milk = milk;
        }

        //Finalizer eller destruktor (destruct) (Använd tillsammans med IDisposable)
        ~CupOfCoffee()
        {

        }
    }
}
