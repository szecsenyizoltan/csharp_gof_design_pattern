using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Logic
{
    internal class TxtExporter : IVisitor
    {

        public void Visit(IAcceptor acceptor)
        {
            File.Delete(acceptor.Item.GetType().Name + ".txt");
            var props = acceptor.Item.GetType().GetProperties();
            foreach (var prop in props.Where(t => t.Name != "Item"))
            {
                File.AppendAllText(
                    acceptor.Item.GetType().Name + ".txt",
                    prop.Name + ": " + prop.GetValue(acceptor.Item) + "\r\n");
            }
        }

    }
}
