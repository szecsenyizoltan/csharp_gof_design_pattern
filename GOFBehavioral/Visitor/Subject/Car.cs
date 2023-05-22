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
    internal class Car : IAcceptor
    {
        public Car(string model, int price)
        {
            Model = model;
            Price = price;
        }

        public string Model { get; set; }

        public int Price { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public object Item => this;

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
