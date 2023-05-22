using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Models;

namespace TemplateMethod.Logic
{
    internal class PersonLogicJson : PersonLogicOlder
    {
        public PersonLogicJson(string filename) : base(filename)
        {

        }

        protected override void Import()
        {
            string data = File.ReadAllText(filename);
            people = JsonConvert.DeserializeObject<List<Person>>(data);
        }
    }
}
