using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Animals
{
    public class Cow : Animal
    {
        /// <summary>
        /// Tre slash ger ett kommentarsfält.
        /// </summary>
        /// <param name="ageInYears"></param>

        public Cow(int ageInYears) : base(ageInYears)
        {
        }

        public override void EatFood()
        {
            //throw new NotImplementedException();

            //Denna metod saknar implementation men det är okej då det inte finns någon returtyp.
        }

        public void SupplyMilk()
        {

        }
    }
}
