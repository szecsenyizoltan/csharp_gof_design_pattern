using ChainOfResponsibility01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility01.Validators
{
    internal abstract class ValidatorBase
    {
        public abstract bool Validate(Person person);
    }
}
