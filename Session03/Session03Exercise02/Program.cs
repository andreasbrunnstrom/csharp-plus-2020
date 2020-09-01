using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Session03Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konvertera det inmatade värdena från strängar till siffror
            // Resultatet skall presentera:
            // Lägsta värdet
            // Högsta värdet
            // Medelvärde (snitt)
            // Programmet skall vara felhanterat
            // Felaktiga värden får inte påverka medelvärde, lägsta eller högsta.

            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            var input = Console.ReadLine();
            var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);

            int?[] arrTal = new int?[inputArray.Length];
            
            for (int i = 0; i < inputArray.Length; i++)
            {
                try
                {
                    arrTal[i] = Convert.ToInt32(inputArray[i]);
                }
                catch
                {
                    arrTal[i] = null;
                    continue;
                }              
            }
            int? minValue = arrTal[0];
            int? totValue = 0;
            int? maxValue = arrTal[0];
            for (int i = 0; i < arrTal.Length; i++)
            {
                totValue += arrTal[i];
                if (arrTal[i] > maxValue)
                {
                    maxValue = arrTal[i];
                    if (minValue == 0) { minValue = arrTal[i]; }
                }
                else if (arrTal[i] < minValue)
                {
                    minValue = arrTal[i];
                }
            }
            // Logic error - average number missing when chars are inputed from user.
            // With conversion to Decimal it becomes 0.
            Console.WriteLine(minValue + " " + totValue/arrTal.Length + " " + maxValue);
            Console.WriteLine();
        }
    }
}
