using Observer.Subject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subscribers
{
    internal class Repository : ISubscriber
    {
        public void Save(Person p)
        {
            File.WriteAllText("person.txt", p.Name + "\r\n" + p.Salary);
        }

        public void StateChange(Person p)
        {
            Save(p);
        }
    }
}
