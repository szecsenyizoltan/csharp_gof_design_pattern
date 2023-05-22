using Memento.Models;
using System;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person peter = new Person("Peter", 18, "spider-man");
            peter.Age = 20;
            peter.Age = 30;
            peter.Age = 40;
            peter.Undo();
            peter.Undo();
            peter.Undo();
            Console.WriteLine(peter.Name);
            Console.WriteLine(peter.Age);
            Console.WriteLine(peter.Job);

        }
    }
}
