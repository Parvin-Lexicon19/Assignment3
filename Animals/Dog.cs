using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Dog : Animal
    {
        public Dog (bool isPoliceDog, string name, double weight, double age) : base(name, weight, age)
        {
            IsPoliceDog = isPoliceDog;
        }

        public string Speak()
        {
            return "Woff!";
        }
        public override string Stats()
        {
            return base.Stats() + $", Is polic dog?: {IsPoliceDog}";
        }
        public bool IsPoliceDog { get; set; }
    }
}
