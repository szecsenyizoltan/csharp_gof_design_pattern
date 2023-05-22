using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Logic
{
    internal class PersonLogicOlder : PersonLogic
    {
        public PersonLogicOlder(string filename) : base(filename)
        {

        }

        protected override void Validate()
        {
            people = people.Where(t => t.Age > 25).ToList();
        }
    }
}
