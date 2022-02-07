﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Model}:");
            sb.AppendLine();
            sb.Append(Engine.ToString());
            sb.AppendLine();
            sb.Append(Weight == 0 ? "  Weight: n/a" : $"  Weight: {Weight}");
            sb.AppendLine();
            sb.Append(String.IsNullOrEmpty(Color) ? "  Color: n/a" : $"  Color: {Color}");

            return sb.ToString().TrimEnd();
        }
    }
}
