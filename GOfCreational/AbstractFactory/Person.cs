using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Person
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }
    }

    internal class Manager : Person
    {
        public int WorkerNumber { get; set; }
    }

    internal class Developer : Person
    {
        public bool DualMonitor { get; set; }
    }

    internal class Trainee : Person
    {
        public string SchoolName { get; set; }

        public int Hour { get; set; }
    }

    internal class Tester : Person
    {
        public string UnitFwName { get; set; }

        public int AcceptTestRequiredNumber { get; set; }
    }
}
