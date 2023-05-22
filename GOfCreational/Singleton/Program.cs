using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = Configuration.Instance;
            config.IpAddress = "172.16.3.3";
            config.PortNumber = 7777;
            Upload();
            Download();
        }

        static void Upload()
        {
            var config = Configuration.Instance;
        }

        static void Download()
        {
            var config = Configuration.Instance;
        }
    }
}
