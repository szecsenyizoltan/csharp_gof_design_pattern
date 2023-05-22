using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Classes
{
    public class Letter : Shape
    {
        char letter;
        int x;
        int y;
        IShapeColor color;
        public Letter(char letter, int x, int y, IShapeColor color)
        {
            this.letter = letter;
            this.x = x;
            this.y = y;
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
            Console.SetCursorPosition(y, x);
            Console.Write(letter);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
