using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subscribers
{
    internal interface ISubscriber
    {
        void StateChange(Person p);
    }
}
