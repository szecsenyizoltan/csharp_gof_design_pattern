using Proxy.System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Telemetry
{
    internal class RepositoryProxy : IRepository
    {
        IRepository system;
        public RepositoryProxy(IRepository system)
        {
            this.system = system;
        }

        public void AddName(string name)
        {
            File.AppendAllText("log.txt", DateTime.Now.ToShortDateString() + ": Create\r\n");
            system.AddName(name);
        }

        public string[] ListNames()
        {
            File.AppendAllText("log.txt", DateTime.Now.ToShortDateString() + ": List\r\n");
            return system.ListNames();
        }

        public void RemoveName(string name)
        {
            File.AppendAllText("log.txt", DateTime.Now.ToShortDateString() + ": Remove\r\n");
            system.RemoveName(name);
        }
    }
}
