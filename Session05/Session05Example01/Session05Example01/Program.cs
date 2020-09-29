using Session05Animals;
using System;

namespace Session05Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            var beanType = CupOfCoffee.DefaultBeanType;

            Animal myAnimal = new Chicken(2);
            myAnimal = new Cow(3);

            //Tvinga datakonvertering
            //Kan generera invalidcastexception
            Cow myCow = (Cow)myAnimal;

            //Säkrad kod
            //Genererar null om konverteringen misslyckas
            myCow = myAnimal as Cow;

            IBarnyardAnimal myBarnyardAnimal = new Chicken(2);
            myBarnyardAnimal.FeedingArea = "Main yard";
            //myBarnyardAnimal.ResingArea = ""; (only get)

            myAnimal = (Animal)myBarnyardAnimal;

            Chicken myChicken = new Chicken(2);
        }
    }
}
