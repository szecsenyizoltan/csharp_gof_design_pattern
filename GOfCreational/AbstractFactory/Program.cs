using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> workers = File.ReadAllLines("data.txt")
                .Select(t => PersonFactoryReflection.CreatePerson(t))
                .ToList();



            //legacy code
            //List<Person> workers = new List<Person>();
            //string[] lines = File.ReadAllLines("data.txt");

            //foreach (string item in lines)
            //{
            //    string[] splitter = item.Split(':', ',', '|');
            //    if (item.StartsWith("Manager"))
            //    {
            //        workers.Add(new Manager()
            //        {
            //            Name = splitter[1],
            //            BirthDate = DateTime.Parse(splitter[2]),
            //            WorkerNumber = int.Parse(splitter[3])
            //        });
            //    }
            //    else if (item.StartsWith("Developer"))
            //    {
            //        workers.Add(new Developer()
            //        {
            //            Name = splitter[1],
            //            BirthDate = DateTime.Parse(splitter[2]),
            //            DualMonitor = bool.Parse(splitter[3])
            //        });
            //    }
            //    else if (item.StartsWith("Trainee"))
            //    {
            //        workers.Add(new Trainee()
            //        {
            //            Name = splitter[1],
            //            BirthDate = DateTime.Parse(splitter[2]),
            //            SchoolName = splitter[3],
            //            Hour = int.Parse(splitter[4])
            //        });
            //    }
            //    else
            //    {
            //        throw new Exception("Data format error");
            //    }
            //}
            
        }
    }
}
