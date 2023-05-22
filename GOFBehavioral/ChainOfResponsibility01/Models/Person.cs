using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility01.Models
{
    internal class Person
    {
        public Person(string name, int age, bool condition)
        {
            Name = name;
            Age = age;
            Condition = condition;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public bool Condition { get; set; }
    }
}
