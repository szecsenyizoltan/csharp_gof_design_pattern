using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Classes
{
    internal interface IWorkItem
    {
        string Name { get; set; }

        void AddChild(IWorkItem item);
        
        void RemoveChild(IWorkItem item);
        
        void Display(int level);
    }
}
