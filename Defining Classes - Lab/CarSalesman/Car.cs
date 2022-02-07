using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Model}:");
            sb.AppendLine(Engine.ToString());
            sb.AppendLine($"Weight: {(Weight.HasValue ? Weight.Value.ToString() : "n/a")}");
            sb.AppendLine($"Color: {Color ?? "n/a"}");

            return sb.ToString().TrimEnd();
        }
    }
}
