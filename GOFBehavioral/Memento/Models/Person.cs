using Memento.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Memento.Models
{
    internal class Person
    {
        MementoStore store;
        public Person(string name, int age, string job)
        {
            this.store = new MementoStore();
            this.name = name;
            this.age = age;
            this.job = job;
            store.Save(CreateMemento());
        }

        private PersonMemento CreateMemento()
        {
            return new PersonMemento()
            {
                Name = this.Name,
                Age = this.Age,
                Job = this.Job
            };
        }

        public Person()
        {
            
        }

        private string name;
        private int age;
        private string job;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
                store.Save(CreateMemento());
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
                store.Save(CreateMemento());
            }
        }
        public string Job
        {
            get
            {
                return job;
            }
            set
            {
                this.job = value;
                store.Save(CreateMemento());
            }
        }

        public void Undo()
        {
            var memento = store.Undo();
            this.name = memento.Name;
            this.age = memento.Age;
            this.job = memento.Job;
        }

    }
}
