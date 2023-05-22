using ChainOfResponsibility01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility01.Validators
{
    internal class AgeValidator : ValidatorBase
    {
        public override bool Validate(Person person)
        {
            return person.Age >= 18;
        }
    }
}
