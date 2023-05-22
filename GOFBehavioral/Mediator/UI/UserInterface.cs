using Mediator.Mediator;
using Mediator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.UI
{
    internal class UserInterface
    {
        List<Person> people;

        Messenger messenger;

        public UserInterface(Messenger messenger)
        {
            this.messenger = messenger;
            this.people = new List<Person>();
            this.messenger.Register("createfromrepo", t => people.Add(t));
        }

        public void Show()
        {
            Console.Clear();
            Console.WriteLine("1: Create");
            Console.WriteLine("2: List");
            Console.Write("Enter menu item: ");
            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1: Create();break;
                case 2: List();break;
                default:
                    break;
            }
        }

        public void Create()
        {
            Person p = new Person();
            Console.Write("Enter name: ");
            p.Name = Console.ReadLine();
            Console.Write("Enter job: ");
            p.Job = Console.ReadLine();
            //todo create call
            messenger.Send("createfromui", p);
            Show();
        }

        public void List()
        {
            foreach (var item in people)
            {
                Console.WriteLine(item.Name + " (" + item.Job + ")");
            }
            Console.ReadLine();
            Show();
        }
    }
}
