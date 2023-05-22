using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.System
{
    internal class Repository : IRepository
    {
        string filepath;

        public Repository(string filepath)
        {
            this.filepath = filepath;
        }
        public void AddName(string name)
        {
            File.AppendAllText(filepath, name + "\r\n");
        }

        public string[] ListNames()
        {
            return File.ReadAllLines(filepath);
        }

        public void RemoveName(string name)
        {
            string[] lines = File.ReadAllLines(filepath);
            File.WriteAllLines(filepath, lines.Where(t => t != name).ToArray());
        }
    }
}
