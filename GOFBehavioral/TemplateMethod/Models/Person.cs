using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Models
{
    internal class Person
    {
        public Person(string name, int age, string job)
        {
            Name = name;
            Age = age;
            Job = job;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Job { get; set; }
    }
}
