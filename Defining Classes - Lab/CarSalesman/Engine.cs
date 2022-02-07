using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public int? Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  {Model}:");
            sb.AppendLine($"    Power: {Power}");
            sb.AppendLine($"    Displacement: {(Displacement.HasValue ? Displacement.Value.ToString() : "n/a")}");
            sb.AppendLine($"    Efficiency: {Efficiency ?? "n/a"}");

            return sb.ToString().TrimEnd();
        }
    }
}
