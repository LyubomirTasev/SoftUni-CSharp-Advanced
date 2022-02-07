using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                var engine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
                var cargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
                var tires = new[]
                {
                    new Tires(double.Parse(carInfo[5]), int.Parse(carInfo[6])),
                    new Tires(double.Parse(carInfo[7]), int.Parse(carInfo[8])),
                    new Tires(double.Parse(carInfo[9]), int.Parse(carInfo[10])),
                    new Tires(double.Parse(carInfo[11]), int.Parse(carInfo[12]))
                };

                cars.Add(new Car(carInfo[0], engine, cargo, tires));
            }

            string type = Console.ReadLine();
            var filtered = new List<Car>();
            filtered = type == "fragile"
                ?
                cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1)).ToList()
                :
                cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250).ToList();

            foreach (var car in filtered)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
