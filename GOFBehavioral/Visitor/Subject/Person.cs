using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Subject
{
    internal class Person : IAcceptor
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public object Item => this;

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
