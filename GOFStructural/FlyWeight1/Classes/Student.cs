using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight1.Classes
{
    internal class Student
    {
        public Student(string name, int mark, int missedLectures)
        {
            Name = name;
            Mark = mark;
            MissedLectures = missedLectures;
        }

        public string Name { get; set; }

        public int Mark { get; set; }

        public int MissedLectures { get; set; }
    }
}
