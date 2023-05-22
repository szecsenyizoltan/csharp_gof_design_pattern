using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Models;

namespace TemplateMethod.Logic
{
    internal class PersonLogic
    {
        protected List<Person> people;
        protected readonly string filename;

        public PersonLogic(string filename)
        {
            people = new List<Person>();
            this.filename = filename;
            Import();
            Validate();
        }
        protected virtual void Import()
        {
            people = File.ReadAllLines("data.dat").Select(t =>
            {
                string[] splitter = t.Split();
                return new Person(splitter[0], int.Parse(splitter[2]), splitter[1]);
            }).ToList();
        }

        protected virtual void Validate()
        {
            people = people.Where(t => t.Age > 18).ToList();
        }

        public IEnumerable<Person> Filter(Func<Person, bool> filterfunc)
        {
            return people.Where(t => filterfunc(t));
        }
    }
}
