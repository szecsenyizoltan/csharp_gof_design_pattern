using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Student : INeptunUser
    {
        public Student(string neptunCode, string name, double mark)
        {
            NeptunCode = neptunCode;
            Name = name;
            Mark = mark;
        }

        public string NeptunCode { get; set; }

        public string Name { get; set; }

        public double Mark { get; set; }
    }
}
