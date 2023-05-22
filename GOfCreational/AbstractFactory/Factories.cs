using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface IPersonFactory
    {
        Person CreateFromText(string line);
    }

    internal class ManagerFactory : IPersonFactory
    {
        public Person CreateFromText(string line)
        {
            string[] splitter = line.Split(':', ',', '|');
            return new Manager()
            {
                Name = splitter[1],
                BirthDate = DateTime.Parse(splitter[2]),
                WorkerNumber = int.Parse(splitter[3])
            };
        }
    }

    internal class DeveloperFactory : IPersonFactory
    {
        public Person CreateFromText(string line)
        {
            string[] splitter = line.Split(':', ',', '|');
            return new Developer()
            {
                Name = splitter[1],
                BirthDate = DateTime.Parse(splitter[2]),
                DualMonitor = bool.Parse(splitter[3])
            };
        }
    }

    internal class TraineeFactory : IPersonFactory
    {
        public Person CreateFromText(string line)
        {
            string[] splitter = line.Split(':', ',', '|');
            return new Trainee()
            {
                Name = splitter[1],
                BirthDate = DateTime.Parse(splitter[2]),
                SchoolName = splitter[3],
                Hour = int.Parse(splitter[4])
            };
        }
    }

    internal class TesterFactory : IPersonFactory
    {
        public Person CreateFromText(string line)
        {
            string[] splitter = line.Split(':', ',', '|');
            return new Tester()
            {
                Name = splitter[1],
                BirthDate = DateTime.Parse(splitter[2]),
                UnitFwName = splitter[3],
                AcceptTestRequiredNumber = int.Parse(splitter[4])
            };
        }
    }

}
