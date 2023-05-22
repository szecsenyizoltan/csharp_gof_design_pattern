using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Classes
{
    internal class Employee : IWorkItem
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            this.Name = name;
        }

        public void AddChild(IWorkItem item)
        {
            throw new NotImplementedException();
        }

        public void RemoveChild(IWorkItem item)
        {
            throw new NotImplementedException();
        }

        public void Display(int level)
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine(Name);
        }

        
    }
}
