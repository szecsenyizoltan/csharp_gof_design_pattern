using ChainOfResponsibility01.Models;
using ChainOfResponsibility01.Validators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("Aladár", 16, true),
                new Person("Ali", 20, true),
                new Person("Béla", 20, false),
                new Person("Dezső", 25, true),
                new Person("Géza", 20, true),
                new Person("Pál", 10, false)
            };

            List<Person> acceptedPeople = new List<Person>();

            var validatorFactory = new ValidatorFactory();
            var validators = validatorFactory.GetValidators();
            var validatorNums = validators.Count(t => true);

            foreach (var person in people)
            {
                int counter = 0;
                foreach (var validator in validators)
                {
                    if (validator.Validate(person))
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter == validatorNums)
                {
                    acceptedPeople.Add(person);
                }
            }
            ;

            
        }
    }
}
