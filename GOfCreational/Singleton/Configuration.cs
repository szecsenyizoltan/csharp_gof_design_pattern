using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Configuration
    {
        public string IpAddress { get; set; }

        public int PortNumber { get; set; }

        private static readonly object lockobject = new object();


        private static Configuration instance = null;

        public static Configuration Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockobject)
                    {
                        if (instance == null)
                        {
                            instance = new Configuration();
                        }
                    }
                }
                return instance;
            }
        }

    }
}
