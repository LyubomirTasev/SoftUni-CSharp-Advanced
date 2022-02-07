using System;
using System.Collections.Generic;

namespace CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineInfo = Console.ReadLine().Split();
                engines.Add(CreateEngine(engineInfo));
            }

            int numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                cars.Add(CreateCar(carInfo, engines));
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        private static Car CreateCar(string[] carInfo, List<Engine> engines)
        {
            string carModel = carInfo[0];
            string engineModel = carInfo[1];
            Engine engine = engines.Find(e => e.Model == engineModel);

            Car car = new Car(carModel, engine);

            if (carInfo.Length > 2)
            {
                bool isDigit = int.TryParse(carInfo[2], out int weight);

                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = carInfo[2];
                }

                if (carInfo.Length > 3)
                {
                    car.Color = carInfo[3];
                }
            }

            return car;
        }

        public static Engine CreateEngine(string[] engineInfo)
        {
            Engine engine = new Engine(engineInfo[0], int.Parse(engineInfo[1]));

            if (engineInfo.Length > 2)
            {
                bool isDigit = int.TryParse(engineInfo[2], out int displacement);

                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = engineInfo[2];
                }

                if (engineInfo.Length > 3)
                {
                    engine.Efficiency = engineInfo[3];
                }
            }

            return engine;
        }
    }
}
