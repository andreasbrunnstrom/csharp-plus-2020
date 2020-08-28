using System;

namespace Session03Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            var input = Console.ReadLine();
            var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);

            foreach (var number in inputArray)
            {
                Console.WriteLine("Värdet är: " + number);
            }
            //Minsta,högsta och medel värde utskrift.
        }
    }
}
