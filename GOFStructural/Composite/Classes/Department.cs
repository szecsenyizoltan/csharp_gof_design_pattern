using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Classes
{
    internal class Department : IWorkItem
    {
        public string Name { get; set; }
        List<IWorkItem> Items = new List<IWorkItem>();

        public Department(string name)
        {
            this.Name = "[" + name.ToUpper() + "]";
        }

        public void AddChild(IWorkItem item)
        {
            Items.Add(item);
        }

        public void RemoveChild(IWorkItem item)
        {
            Items.Remove(item);
        }

        public void Display(int level)
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine(Name);
            foreach (var item in Items)
            {
                item.Display(level + 1);
            }
        }

        
    }
}
