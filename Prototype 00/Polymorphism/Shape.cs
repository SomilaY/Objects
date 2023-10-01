using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_00.Polymorphism
{
    internal class Shape
    {
       protected double length;
        protected double width;

        public Shape()
        { }

        public Shape(double theLength, double theWidth)
        {
         this.length = theLength;
            this.width = theWidth;
        }

        public virtual double Area() 
        {
        return length * width;
        }
        public void printName()
        {
            Console.WriteLine("This is a shape");
        }


    }
}
