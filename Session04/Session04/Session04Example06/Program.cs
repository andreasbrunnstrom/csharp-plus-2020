using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;

namespace Session04Example06
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;

            //Generic time Universal..
            DateTime currentTimeZoneNeutralDateTime = DateTime.UtcNow;

            DateTime.IsLeapYear(currentDateTime.Date.Year);

            DateTime minValue = DateTime.MaxValue;
            DateTime maxValue = DateTime.MinValue;

            //Från sträng
            var parsed = DateTime.Parse("2000-06-28");
            //DateTime failedParsedDate = DateTime.Parse("kkk");

            bool dataWasParsed = DateTime.TryParse("kkk", out parsed);

            // Tiden
            TimeSpan currentTime = currentDateTime.TimeOfDay;
            var lowestCount = currentTime.Ticks;
            TimeSpan createdTime = new TimeSpan(1, 2, 3);

            Stopwatch timer = new Stopwatch();
            timer.Start();
            timer.Stop();

            // Pausa med millisec som input i metoden.
            Thread.Sleep(1000);

            DateTime today = DateTime.Today;
            DateTime yesterday = DateTime.Today.AddDays(-1).AddSeconds(-1);

            TimeSpan resultOfTwoTimes = today - yesterday;
            TimeSpan negativeResultOfTwoTimes = yesterday - today;

            // Formatera datum specifikt resultat.
            Console.WriteLine($"{currentDateTime:yyyy-MM-dd}");

            // Formatera datum på ett specifikt språk.
            Console.WriteLine($"{currentDateTime.ToString(CultureInfo.InvariantCulture)}");

            Console.WriteLine(createdTime + " " + timer.ElapsedTicks + " " + resultOfTwoTimes);

            //Slumptal , endast 1 object/instans annars blir det inte random.
            Random randomizer = new Random();
            int slumpTal1 = randomizer.Next(0,100);
            int slumpTal2 = randomizer.Next(0,100);

            // Experiment med slump
            IDictionary<int, int> randomNumbersFromGlobalRandomizer = new Dictionary<int, int>(100);
            IDictionary<int, int> randomNumbersFromLocalRandomizer = new Dictionary<int, int>(100);

            for (var i = 0; i < 10000; i++)
            {
                int globalRandomNumber = randomizer.Next(0, 100);

                if (randomNumbersFromGlobalRandomizer.ContainsKey(globalRandomNumber))
                {
                    randomNumbersFromGlobalRandomizer[globalRandomNumber]++;
                }
                else
                {
                    randomNumbersFromGlobalRandomizer.Add(globalRandomNumber, 1);
                }

                int localRandomNumber = new Random().Next(0, 100);

                if (randomNumbersFromLocalRandomizer.ContainsKey(localRandomNumber))
                {
                    randomNumbersFromLocalRandomizer[localRandomNumber]++;
                }
                else
                {
                    randomNumbersFromLocalRandomizer.Add(localRandomNumber, 1);
                }
            }
        }
    }
}
