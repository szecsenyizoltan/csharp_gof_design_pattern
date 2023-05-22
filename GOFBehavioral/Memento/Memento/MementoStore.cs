using Memento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    internal class MementoStore
    {
        Stack<PersonMemento> memento;

        public MementoStore()
        {
            memento = new Stack<PersonMemento>();
        }
        public void Save(PersonMemento p)
        {
            var mementoitem = new PersonMemento();
            mementoitem.Name = p.Name;
            mementoitem.Age = p.Age;
            mementoitem.Job = p.Job;
            memento.Push(mementoitem);
        }

        public PersonMemento Undo()
        {
            var upper = this.memento.Pop();
            var current = this.memento.Pop();
            this.memento.Push(upper);
            return current;
        }
    }
}
