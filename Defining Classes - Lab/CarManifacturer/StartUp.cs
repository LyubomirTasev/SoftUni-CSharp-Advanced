using System;

namespace CarManifacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var engine = new Engine(300, 3.0);
            var tire = new Tire(2014, 3.0);

            var car = new Car("Mazda", "CX7", 2010, 200, 15, engine, tire)
            {
                FuelQuantity = 200,
                FuelConsumption = 200
            };
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());

            Console.WriteLine($"{car.Make} {car.Model} - {car.Year}");
            Console.WriteLine(car);
        }
    }
}
