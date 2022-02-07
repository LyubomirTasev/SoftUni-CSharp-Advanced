using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tires
    {
        public double Pressure { get; set; }
        public int Age { get; set; }

        public Tires(double tirePressure, int tireAge)
        {
            this.Pressure = tirePressure;
            this.Age = tireAge;
        }
    }
}
