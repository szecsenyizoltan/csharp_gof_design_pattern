using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility01.Validators
{
    internal class ValidatorFactory
    {
        public IEnumerable<ValidatorBase> GetValidators()
        {
            return new List<ValidatorBase>()
            {
                new NameValidator(),
                new AgeValidator(),
                new ConditionValidator()
            };
        }
    }
}
