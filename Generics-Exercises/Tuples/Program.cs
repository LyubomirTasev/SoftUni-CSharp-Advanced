using System;
using System.Linq;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nameTownInput = Console.ReadLine().Split();
            string name = $"{nameTownInput[0]} {nameTownInput[1]}";
            string address = nameTownInput[2];
            string city = string.Join(" ", nameTownInput.Skip(3)); // !!! 

            string[] nameBeerInput = Console.ReadLine().Split();
            string beerName = nameBeerInput[0];
            int liters = int.Parse(nameBeerInput[1]);
            bool isDrunk = nameBeerInput[2] == "drunk";

            string[] numbersInput = Console.ReadLine().Split();
            string personsName = numbersInput[0];
            double doubly = double.Parse(numbersInput[1]);
            string currency = numbersInput[2];

            Threeple<string, string, string> nameTown = new Threeple<string, string, string>(name, address, city);

            Threeple<string, int, bool> nameBeer = new Threeple<string, int, bool>(name, liters, isDrunk);

            Threeple<string, double, string> numbers = new Threeple<string, double, string>(personsName, doubly, currency);

            Console.WriteLine(nameTown.GetItems());
            Console.WriteLine(nameBeer.GetItems());
            Console.WriteLine(numbers.GetItems());
        }
    }
}
