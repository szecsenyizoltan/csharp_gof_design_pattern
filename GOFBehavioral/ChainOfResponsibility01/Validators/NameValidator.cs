using ChainOfResponsibility01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility01.Validators
{
    internal class NameValidator : ValidatorBase
    {
        public override bool Validate(Person person)
        {
            return person.Name.Length > 3;
        }
    }
}
