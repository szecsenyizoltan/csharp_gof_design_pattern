using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility02
{
    internal class Boss
    {
        public Boss(string name, int limit)
        {
            Name = name;
            Limit = limit;
        }

        public Boss(Boss principal, string name, int limit)
        {
            Principal = principal;
            Name = name;
            Limit = limit;
        }

        public bool AcceptRequest(string item, int price)
        {
            if (Limit > price)
            {
                Console.WriteLine("log: " + this.Name + " accepted");
                return true;
            }
            else if (Principal == null)
            {
                Console.WriteLine("log: " + this.Name + " declined");
                return false;
            }
            else
            {
                Console.WriteLine("log: " + this.Name + " forwarded");
                return Principal.AcceptRequest(item, price);
            }
        }

        public Boss Principal { get; set; }

        public string Name { get; set; }

        public int Limit { get; set; }
    }
}
