using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_00.Polymorphism
{
    internal class Square : Shape
    {
        
        public Square(double theSide) :base(theSide,0)
        {
           //this.length = theSide;
        }


        public override double Area()
        {
            return length * length;
        }
        
    }
}
