using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Animal
    {
        public Animal(string name, double weight, double age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public virtual string Stats()
        {
            return $"Animal Name: {Name}, Weight: {Weight}kg, Age: {Age} ";
        }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Age { get; set; }
    }
}
