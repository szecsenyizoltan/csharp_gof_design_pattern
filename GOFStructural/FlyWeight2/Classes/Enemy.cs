using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight2.Classes
{
    class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
    internal class Enemy
    {
        public Enemy(string name, ConsoleColor color, Point location)
        {
            Name = name;
            Color = color;
            Location = location;
        }

        public string Name { get; set; }

        public ConsoleColor Color { get; set; }

        public Point Location { get; set; }


        //shared


        public List<Point> Points
        {
            get
            {
                return Drawing;
            }
        }

        static List<Point> Drawing
        {
            get
            {
                return new List<Point>
                {
                    new Point(0, 1),
                    new Point(0, -1),
                    new Point(1, 0),
                    new Point(-1, 0),
                    new Point(0,0)
                };
            }
        }

        public void Draw()
        {
            Console.ForegroundColor = Color;
            foreach (Point item in Points)
            {
                Console.SetCursorPosition(Location.Y + item.Y, Location.X + item.X);
                Console.Write('█');
            }
        }
    }
}
