using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;

namespace Session03Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            //string input = Console.ReadLine();
            //string[] inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);          

            //double[] numArray = new double[inputArray.Length];

            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    try
            //    {
            //        numArray[i] = Convert.ToDouble(inputArray[i]);
            //    }
            //    catch (Exception)
            //    {
            //        numArray[i] = 0;
            //    }
            //}

            //double low = numArray[0]; 
            //double high = 0;
            //double avg = 0;
            //double totalCount = 0;

            //foreach(var el in numArray)
            //{
            //    if (el < high && el < low)
            //    { low = el; }
            //    else if (el > high)
            //    { high = el; }
            //    totalCount += el;
            //}

            //avg = totalCount / numArray.Length;

            //{
            //    Console.WriteLine(low + " " + high + " " + avg);
            //}
            //Assignment done.
            //More on try/catch with exeptions followed.

            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);

            double?[] numArray = new double?[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                NumberStyles numberStyle = NumberStyles.Integer | NumberStyles.Float;
                IFormatProvider formatProvider = CultureInfo.InvariantCulture;

                bool parsed = double.TryParse(inputArray[i], numberStyle, CultureInfo.InvariantCulture, out double parsedValue);

                if (parsed == true)
                {
                    numArray[i] = parsedValue;
                }
                else
                {
                    numArray[i] = null;
                }
            }

            // Metod som returnerar en siffra baserat på en sträng
            static double GetDoubleValue(string input)
            {
                try
                {
                    var result = int.Parse(input);

                    return result;
                }
                catch(FormatException ex) when(ex.Message.Contains("Input string"))
                {
                    return double.MinValue;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }

            // Metod som returnerar ett heltal, saknar inparameter
            static int GetExceptionStatus()
            {
                int exceptionResult;

                try
                {
                    exceptionResult = -1;

                    throw new Exception("Provocerat fel");

                    return exceptionResult;
                }
                catch (Exception ex)
                {
                    exceptionResult = ex.HResult;

                    return exceptionResult;
                }
                finally
                {
                    exceptionResult = int.MaxValue;
                }
            }
        }
    }
}
