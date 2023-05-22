using System;
using System.Collections.Generic;
using Visitor.Interfaces;
using Visitor.Logic;
using Visitor.Subject;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JsonExporter jExporter = new JsonExporter();
            TxtExporter tExporter = new TxtExporter();

            Car c = new Car("Audi A4", 2000);
            Person p = new Person("Géza", 56);

            List<IVisitor> visitors = new List<IVisitor>() { jExporter, tExporter };
            List<IAcceptor> acceptors = new List<IAcceptor>() { c, p };

            foreach (var visitor in visitors)
            {
                foreach (var acceptor in acceptors)
                {
                    acceptor.Accept(visitor);
                }
            }
        }
    }
}
