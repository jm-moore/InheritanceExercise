using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public string TypeOfBird { get; set; }
        public string Sound { get; set; }
        public bool CanFly { get; set; }
        public string Color { get; set; }
    }
}
