using System;
using System.Collections.Generic;
using System.Text;

namespace CarManifacturer
{
    public class Engine
    {
        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        public int HorsePower { get; private set; }
        public double CubicCapacity { get; private set; }
    }
}
