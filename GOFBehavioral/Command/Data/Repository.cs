using Command.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Data
{
    internal class Repository
    {
        List<Person> people;

        public IEnumerable<Person> People { get => people; }

        public Repository()
        {
            people = new List<Person>();
        }
        public void Add(Person p)
        {
            people.Add(p);
        }

        public void Delete(int id)
        {
            people.Remove(people[id]);
        }
    }
}
