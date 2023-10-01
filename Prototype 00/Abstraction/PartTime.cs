using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_00.Abstraction
{
    internal class PartTime : Student
    {
        public override void RegisterForCourse()
        {
            Console.WriteLine("Register for full time classes");
        }
    }
}
