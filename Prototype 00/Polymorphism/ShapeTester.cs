using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_00.Polymorphism
{
    internal class ShapeTester
    {
        static void Main(string[] args)
        {
            Shape s = new Shape(5, 7);
            Console.WriteLine("Area: " + s.Area());

            Square sq = new Square(5);
            Console.WriteLine("Square Area: " + sq.Area());

            Circle circle= new Circle(5);
            Console.WriteLine("Circle : " + circle.Area());
            Console.ReadLine();
        }
    }
}
