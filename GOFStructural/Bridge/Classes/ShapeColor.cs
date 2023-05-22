using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Classes
{
    public class ShapeColor : IShapeColor
    {
        public ConsoleColor Color { get; }

        public string Name { get; }

        public ShapeColor(ConsoleColor color, string name)
        {
            this.Color = color;
            this.Name = name;
        }
    }
}
