using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Person
    {
        public string[] Names { get; set; }

        public Address Address { get; set; }

        public Person GetClone()
        {
            return new Person()
            {
                Address = new Address()
                {
                    Street = this.Address.Street,
                    HouseNumber = this.Address.HouseNumber
                },
                Names = (string[])this.Names.Clone()
            };
        }
        public Person GetClone(bool json)
        {
            string data = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<Person>(data);
        }

    }
}
