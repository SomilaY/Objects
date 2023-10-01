using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_00.Abstraction
{
    internal class ExecuteStudent
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.RegisterForCourse();
        }
    }
}
