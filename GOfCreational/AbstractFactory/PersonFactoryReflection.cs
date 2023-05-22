using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal static class PersonFactoryReflection
    {
        static public Person CreatePerson(string line)
        {
            string entityName = line.Split(':')[0];
            var factoryType = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(t => t.Name == entityName + "Factory");

            var createMethod = factoryType.GetMethod("CreateFromText");

            var factory = Activator.CreateInstance(factoryType);

            var result = createMethod.Invoke(factory, new object[] { line });

            return result as Person;
        }
    }
}
