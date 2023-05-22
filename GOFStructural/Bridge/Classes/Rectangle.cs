using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Classes
{
    public class Rectangle : Shape
    {
        int x, y, height, width;
        IShapeColor color;

        public Rectangle(int x, int y, int width, int height, IShapeColor color)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.color = color;
        }

        public override ConsoleColor Color
        { 
            get
            {
                return color.Color;
            }
        }
        public override void Draw()
        {
            Console.ForegroundColor = Color;
            for (int i = x; i < x + width; i++)
            {
                for (int j = y; j < y + height; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write("█");
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
