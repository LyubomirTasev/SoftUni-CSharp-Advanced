using System;
using System.Collections.Generic;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            string command = Console.ReadLine();

            while (command != "Revision")
            {
                string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shopName = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops[shopName] = new Dictionary<string, double>();
                }

                shops[shopName].Add(product, price);

                command = Console.ReadLine();
            }



            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
