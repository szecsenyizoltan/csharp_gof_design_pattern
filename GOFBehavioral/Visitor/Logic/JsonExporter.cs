using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Logic
{
    internal class JsonExporter : IVisitor
    {
        public void Visit(IAcceptor acceptor)
        {
            string data = JsonConvert.SerializeObject(acceptor.Item, Formatting.Indented);
            File.WriteAllText(acceptor.Item.GetType().Name + ".json", data);
        }
    }
}
