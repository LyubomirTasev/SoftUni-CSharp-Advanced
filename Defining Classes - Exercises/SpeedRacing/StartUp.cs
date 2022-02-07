using System;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new Car[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                decimal fuelAmount = decimal.Parse(tokens[1]);
                decimal fuelCost = decimal.Parse(tokens[2]);

                cars[i] = new Car(model, fuelAmount, fuelCost);
            }

            while (true)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                if (input == "End")
                {
                    break;
                }

                string model = tokens[1];
                decimal distance = decimal.Parse(tokens[2]);
                cars.Where(c => c.Model == model).ToList().ForEach(c => c.Drive(distance));
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Travelled}");
            }
        }
    }
}
