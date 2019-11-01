using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Bird : Animal
    {
        public Bird(double wingspan, string name, double weight, double age) : base(name, weight, age)
        {
            Wingspan = wingspan;
        }

        public override string Stats()
        {
            return base.Stats() + $", Wingspan: {Wingspan}cm";
        }
        public double Wingspan { get; set; }
    }
}
