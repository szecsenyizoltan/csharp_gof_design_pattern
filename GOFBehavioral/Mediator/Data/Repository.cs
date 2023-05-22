using Mediator.Mediator;
using Mediator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Data
{
    internal class Repository
    {
        List<Person> people;

        Messenger messenger;

        public Repository(Messenger messenger)
        {
            this.messenger = messenger;
            people = new List<Person>();
            this.messenger.Register("createfromui", t => Create(t));
        }
        public void Create(Person p)
        {
            people.Add(p);
            this.messenger.Send("createfromrepo", p);
        }
    }
}
