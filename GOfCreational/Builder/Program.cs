using System;
using System.Collections.Generic;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonBuilder builder = new PersonBuilder();
            Person peter = builder
                .SetupNameAndBirthDate("Peter Parker", new DateTime(1990, 01, 20))
                .SetupWorkPlace("Avengers")
                .AddParent(new Person() { Name = "Aunt May" })
                .Person;
            

        }
    }
}
