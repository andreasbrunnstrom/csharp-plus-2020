using System;

namespace Session03Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] integer = new [] { 1,2,3};


            for (var i = 0; i < integer.Length; i++)
            {
                var name = nameof(integer);
                var value = integer[i];

                Console.WriteLine($"Index {i} arrayen {name} har värdet: {value}");
            }
            Console.ReadKey();
        }
    }
}
