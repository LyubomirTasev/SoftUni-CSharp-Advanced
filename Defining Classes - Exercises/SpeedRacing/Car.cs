using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }

        public decimal FuelAmount { get; set; }

        public decimal Consumption { get; set; }

        public decimal Travelled { get; set; }

        public Car(string model, decimal amount, decimal consumption)
        {
            this.Model = model;
            this.FuelAmount = amount;
            this.Consumption = consumption;
            this.Travelled = 0;
        }

        public void Drive(decimal distance)
        {
            decimal fuelNeeded = distance * Consumption;

            if (FuelAmount >= fuelNeeded)
            {
                FuelAmount -= fuelNeeded;
                Travelled += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
