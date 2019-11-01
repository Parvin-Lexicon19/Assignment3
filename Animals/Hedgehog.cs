using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Hedgehog : Animal
    {
        public Hedgehog(int noOfSpikes, string name, double weight, double age) : base(name, weight, age)
        {
            NoOfSpikes = noOfSpikes;
        }

        public override string Stats()
        {
            return base.Stats() + $", No. of spikes: {NoOfSpikes}";
        }
        public int NoOfSpikes { get; set; }
    }
}
