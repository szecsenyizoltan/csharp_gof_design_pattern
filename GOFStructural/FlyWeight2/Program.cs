using FlyWeight2.Classes;
using System;
using System.Collections.Generic;

namespace FlyWeight2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Enemy> enemies = new List<Enemy>();
            enemies.Add(new Enemy("sfesfe", ConsoleColor.Red, new Point(5, 5)));
            enemies.Add(new Enemy("dfgert", ConsoleColor.Green, new Point(10, 2)));
            enemies.Add(new Enemy("rhegze", ConsoleColor.Magenta, new Point(8, 10)));
            enemies.Add(new Enemy("ztzeev", ConsoleColor.Yellow, new Point(3, 7)));
            enemies.Add(new Enemy("jhzztz", ConsoleColor.Cyan, new Point(4, 10)));

            

            foreach (var item in enemies)
            {
                item.Draw();
            }

            Console.ReadKey();
        }
    }
}
