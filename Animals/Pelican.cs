using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Pelican : Bird
    {
        public Pelican(bool isAustralian, double wingspan, string name, double weight, double age) : base(wingspan, name, weight, age)
        {
            IsAustralian = isAustralian;
        }

        public override string Stats()
        {
            return base.Stats() + $", Is Australian?: {IsAustralian}";
        }
        public bool IsAustralian { get; set; }
    }
}
