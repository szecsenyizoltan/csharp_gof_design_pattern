using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal static class PersonFactory
    {
        static Dictionary<string, IPersonFactory> factories;

        static PersonFactory()
        {
            factories = new Dictionary<string, IPersonFactory>();
            factories.Add("Manager", new ManagerFactory());
            factories.Add("Developer", new DeveloperFactory());
            factories.Add("Trainee", new TraineeFactory());
        }

        static public Person CreatePerson(string line)
        {
            string entityName = line.Split(':')[0];
            var factory = factories[entityName];
            return factory.CreateFromText(line);
        }

    }
}
