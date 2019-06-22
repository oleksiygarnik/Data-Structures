using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Car : IEquatable<Car>
    {
        public string Name { get; set; }

        public string Number { get; set; }

        public bool Equals(Car other)
        {
            if (other == null)
                return false;
            return Name == other.Name && Number == other.Number;
        }

        public override string ToString()
        {
            return Name + " " + Number;
        }
    }
}
