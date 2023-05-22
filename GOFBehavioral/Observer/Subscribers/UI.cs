using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subscribers
{
    internal class UI : ISubscriber
    {
        public void Show(Person p)
        {
            Console.Clear();
            Console.WriteLine("Name: " + p.Name);
            Console.WriteLine("Salary: " + p.Salary);
        }

        public void StateChange(Person p)
        {
            Show(p);
        }
    }
}
