using System;
using System.Collections.Generic;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<INeptunUser> users = new List<INeptunUser>()
            {
                new Student("AAA111", "Kiss Géza", 3.4),
                new Student("BBB222", "Nagy Béla", 4.2),
                new Student("CCC333", "Kovács Cecil", 1.8),
                new Student("DDD444", "Szabó Dezső", 5.0),
            };

            Student dezso = users[3] as Student;
            ErasmusStudent dezsoErasmus = new ErasmusStudent(dezso, "Ankara University", DateTime.Now + TimeSpan.FromDays(100));
            users[3] = dezsoErasmus;

            

            foreach (var item in users)
            {
                Console.WriteLine(item.Name + " (" + item.NeptunCode + "): " + item.Mark);
            }
        }
    }
}
