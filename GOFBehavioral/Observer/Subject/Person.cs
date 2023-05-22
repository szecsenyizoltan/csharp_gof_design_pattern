using Observer.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subject
{
    internal class Person
    {
        private string name;
        private int salary;

        public event EventHandler StateChanged;

        //List<ISubscriber> subscribers;

        public Person()
        {
            //subscribers = new List<ISubscriber>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                StateChanged?.Invoke(this, null);
            }
        }
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
                //StateChanged();
                StateChanged?.Invoke(this, null);
            }
        }

        //public void Subscribe(ISubscriber subscriber)
        //{
        //    subscribers.Add(subscriber);
        //}

        //public void UnSubscribe(ISubscriber subscriber)
        //{
        //    subscribers.Remove(subscriber);
        //}

        //private void StateChanged()
        //{
        //    foreach (var item in subscribers)
        //    {
        //        item.StateChange(this);
        //    }
        //}

    }
}
