using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Flamingo : Bird
    {
        public Flamingo(string color, double wingspan, string name, double weight, double age) : base(wingspan, name, weight, age)
        {
            Color = color;
        }

        public override string Stats()
        {
            return base.Stats() + $", Color: {Color}";
        }
        public string Color { get; set; }
    }
}
