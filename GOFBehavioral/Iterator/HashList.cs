using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class HashList : IEnumerable<string>
    {
        public List<string>[] Set { get; set; }

        public HashList()
        {
            Set = new List<string>[26];
            for (int i = 0; i < Set.Length; i++)
            {
                Set[i] = new List<string>();
            }
        }

        public void Add(string item)
        {
            Set[item[0] - 'A'].Add(item);
        }

        public IEnumerator<string> GetEnumerator()
        {
            //return new HashListEnumerator(this);
            for (int i = 0; i < Set.Length; i++)
            {
                for (int j = 0; j < Set[i].Count; j++)
                {
                    yield return Set[i][j];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
