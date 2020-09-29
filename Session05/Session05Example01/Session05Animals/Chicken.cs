using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Animals
{
    public class Chicken : Animal, IBarnyardAnimal
    {
        private string _restingArea;
        private string _feedingArea;

        //Lambdauttryck. prop returnerar det efter =>
        public string ResingArea => _restingArea;

        //Genväg för att kalla på konstruktor i basklass
        public Chicken(int ageInYears) : base(ageInYears)
        {

        }

        public string FeedingArea
        {
            get
            {
                return _feedingArea;
            }
            set
            {
                _feedingArea = value;
            }
        }

        public override void EatFood()
        {
            //throw new NotImplementedException();

            // Implement metod() fyll på med logik.
        }
    }
}
