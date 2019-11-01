using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Swan : Bird
    {
        public Swan(string nebColor, double wingspan, string name, double weight, double age) : base(wingspan, name, weight, age)
        {
            NebColor = nebColor;
        }

        public override string Stats()
        {
            return base.Stats() + $", Neb Color: {NebColor}";
        }
        public string NebColor { get; set; }
    }
}
