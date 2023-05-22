using Mediator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator
{
    internal class Messenger
    {
        Dictionary<string, List<Action<Person>>> handlers;

        public Messenger()
        {
            handlers = new Dictionary<string, List<Action<Person>>>();
        }
        public void Send(string type, Person p)
        {
            foreach (var item in handlers[type])
            {
                item?.Invoke(p);
            }
        }

        public void Register(string type, Action<Person> handler)
        {
            if (!handlers.ContainsKey(type))
            {
                handlers.Add(type, new List<Action<Person>>());
            }
            handlers[type].Add(handler);
        }
    }
}
