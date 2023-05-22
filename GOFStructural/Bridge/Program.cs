using Bridge.Classes;
using System;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShapeColor red = new ShapeColor(ConsoleColor.Red, "piros");
            IShapeColor blue = new ShapeColor(ConsoleColor.Blue, "kék");

            Shape s1 = new Rectangle(3, 3, 5, 5, red);
            s1.Draw();

            Shape s2 = new Rectangle(8, 15, 2, 2, blue);
            s2.Draw();

            Shape s3 = new Letter('C', 20, 20, red);
            s3.Draw();

            Shape s4 = new Letter('D', 2, 2, blue);
            s4.Draw();

            Console.ReadKey();
        }
    }
}
