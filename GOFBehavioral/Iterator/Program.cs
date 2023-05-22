using System;
using System.Linq;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashList list = new HashList();
            list.Add("Aladár");
            list.Add("Andrea");
            list.Add("Béla");
            list.Add("Alfonz");
            list.Add("Cecil");
            list.Add("Boglárka");
            list.Add("Dénes");
            list.Add("Cintia");
            list.Add("Dorottya");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            var endedWithA = list.Where(t => t.EndsWith('a'));
            
        }
    }
}
