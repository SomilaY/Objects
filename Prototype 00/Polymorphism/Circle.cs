using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_00.Polymorphism
{
    internal class Circle : Shape
    {
        public Circle(double radius) { width = radius; }

        public override double Area()
        {
            return Math.PI * (width * width);
        }
    }
}
