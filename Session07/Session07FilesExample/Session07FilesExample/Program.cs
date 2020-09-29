using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Session07FilesExample
{ 
    class Program
    {
        const string _separatoor = ";";

        static void Main(string[] args)
        {
            using (FileStream stream = File.Open("maxfritid.csv", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    // Så här får man ut all text på en gång
                    string fileContent = reader.ReadToEnd();
                }
            }

            // Enklare sätt
            string simpleReadFileContent = File.ReadAllText("maxfritid.csv");

            List<Product> products = new List<Product>();

            using (FileStream stream = File.Open("maxfritid.csv", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        //Logik for raden
                        string[] colums = line.Split(_separatoor);

                        try
                        {
                            Product product = CreateProduct(colums);

                            // Placera behandling av produkter här.
                            products.Add(product);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        line = reader.ReadLine();
                    }
                }
            }
            //Sortera en lista via CompareTo på klassen
            products.Sort();

            //Sortera en lista med en egen comparer
            products.Sort(new ProductNameComparer());
            //Med LINQ
            IEnumerable<Product> productSortedByName = products.OrderBy(x => x, new ProductNameComparer());
            
            //Enklare
            productSortedByName = products.OrderBy(el => el.ProductName)
                   .ThenBy(el => el.Id)
                    .ToList(); // Spara så sortering inte sker varje gång.
                   

            PrintProducts(productSortedByName);
        }

        static void PrintProducts(IEnumerable<Product> products)
        {
            foreach(Product product in products)
            {
                Console.WriteLine($"{product.Id}: {product.ProductNumber}: {product.ProductName}");
            }
        }

        static Product CreateProduct(string[] colums)
        {
            return new Product
            {
                Id = Convert.ToInt32(colums[0]),
                ProductNumber = colums[2],
                ProductName = colums[3],
                ProductBrand = ConvertToNullable(colums[4]),
                ProductSupplier = colums[5],
                ProductSynonyms = ConvertToArray(colums[6])
            };

        }

        static int ConvertToInt(string input)
        {
            int.TryParse(input, out int result);
                return result;
        }

        static int? ConvertToNullable(string input)
        {
            if(int.TryParse(input, out int result))            
            return result;
            else
                return null;
        }

        static string[] ConvertToArray(string input)
        {
            if (input == null)
                return new string[0];
            else
                return input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            
        }
    }
}
