using Command.Commands;
using Command.Data;
using Command.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.UI
{
    internal class UserInterface
    {
        IEnumerable<Person> people;

        public UserInterface(IEnumerable<Person> people)
        {
            this.people = people;
        }

        public CreateCommand CreateCommand { get; set; }
        public DeleteCommand DeleteCommand { get; set; }

        public void Show()
        {
            Console.Clear();
            Console.WriteLine("1: Create");
            Console.WriteLine("2: List");
            Console.WriteLine("3: Delete");
            Console.Write("Enter menu item: ");
            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1: Create();break;
                case 2: List();break;
                case 3: Delete();break;
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
            //repo.Create(p);
            CreateCommand.Execute(p);
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

        public void Delete()
        {
            int index = 0;
            foreach (var item in people)
            {
                Console.WriteLine(index++ + ": " + item.Name + " (" + item.Job + ")");
            }
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            //todo delete call
            //repo.Delete(id);
            DeleteCommand.Execute(id);
            Show();
        }
    }
}
