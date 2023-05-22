using FlyWeight1.Classes;
using System;

namespace FlyWeight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course hft = new Course();
            hft.AddStudent(new Student("Géza", 4, 3));
            hft.AddStudent(new Student("Béla", 5, 2));
            hft.AddStudent(new Student("Sanyi", 3, 0));
            hft.AddStudent(new Student("Józsi", 1, 0));
            hft.AddStudent(new Student("Réka", 1, 5));

            Student szilvi = new Student("Szilvi", 5, 1);
            hft.AddStudent(szilvi);

            Console.WriteLine("Avg Mark: " + hft.AvgMark);
            Console.WriteLine("Avg Missing: " + hft.AvgMissedLectures);

            hft.RemoveStudent(szilvi);
            Console.WriteLine();

            Console.WriteLine("Avg Mark: " + hft.AvgMark);
            Console.WriteLine("Avg Missing: " + hft.AvgMissedLectures);


        }
    }
}
