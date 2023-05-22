using Proxy.System;
using Proxy.Telemetry;
using System;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI(new RepositoryProxy(new Repository("names.txt")));
            ui.Start();
        }
    }
}
