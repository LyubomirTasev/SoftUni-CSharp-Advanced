using System;
using System.Collections.Generic;
using System.Text;

namespace CarManifacturer
{
    public class Car
    {
        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire tire)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.Engine = engine;
            this.Tire = tire;
        }

        public string Make { get; private set; } = "VW";

        public string Model { get; private set; } = "Golf";

        public int Year { get; private set; } = 2025;

        public double FuelQuantity { get; set; } = 200;

        public double FuelConsumption { get; set; } = 10;

        public Engine Engine { get; private set; }

        public Tire Tire { get; private set; }

        public void Drive(double distance)
        {
            bool canContinue = (this.FuelQuantity - (distance * this.FuelConsumption)) >= 0;
            if (canContinue)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make - {this.Make}");
            sb.AppendLine($"Model - {this.Model}");
            sb.AppendLine($"Year - {this.Year}");
            sb.AppendLine($"Fuel - {this.FuelQuantity:f2}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return $"{this.Make} {this.Model} - {this.Year}";
        }
    }
}
