using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Horse : Animal
    {
        public Horse (bool isRacingHorse, string name, double weight, double age) : base (name, weight, age)
        {
            IsRacingHorse = isRacingHorse;
        }

        public override string Stats()
        {
            return base.Stats() + $", Is racing horse?: {IsRacingHorse}";
        }
        public bool IsRacingHorse { get; set; }
    }
}
