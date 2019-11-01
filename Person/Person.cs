using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Person
    {
        private int age;
        private string fName;
        private string lName;
        double height;
        double weight;

        public Person(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            this.fName = fname;
            lName = lname;
            this.height = height;
            this.weight = weight;
        }

        public int Age
        { 
            get
            { 
                return age; 
            } 
            set
            { 
                if(value >= 0)
                age = value; 
            } 
        }
        public string FName {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }
        public string LName {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }
        public double Height {
            get
            {
                return height;
            }
            set
            {
                if (value >= 0)
                    height = value;
            }
        }
        public double Weight {
            get
            {
                return weight;
            }
            set
            {
                if (value >= 0)
                    weight = value;
            }
        }
        
        //This method runs when you call ToString() on a person instance
        public override string ToString()
        {
            return $"First Name: {FName}, Last Name: {LName}, Age: {Age}, Height: {Height}, Weight: {Weight} ";
        }
    }
}
