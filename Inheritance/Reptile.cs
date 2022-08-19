using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public string TypeOfReptile { get; set; }
        public bool CanSwim { get; set; }
        public bool HasScales { get; set; }
        public bool HasTeeth { get; set; }
    }
}
