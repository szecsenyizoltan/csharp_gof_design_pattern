using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    [Obsolete]
    internal class HashListEnumerator : IEnumerator<string>
    {
        HashList list;

        int x;
        int y;

        int fx;
        int fy;
        public HashListEnumerator(HashList list)
        {
            this.list = list;
            int firstListIndex = -1;
            for (int i = 0; i < list.Set.Length; i++)
            {
                if (list.Set[i].Count > 0)
                {
                    firstListIndex = i;
                    break;
                }
            }

            x = firstListIndex;
            y = 0;
            fx = x;
            fy = y;
        }


        public string Current => list.Set[x][y];

        object IEnumerator.Current => list.Set[x][y];

        public void Dispose()
        {

        }

        private bool FindNext(int x, int y)
        {
            for (int i = x; i < list.Set.Length; i++)
            {
                if (i > x)
                {
                    for (int j = 0; j < list.Set[i].Count; j++)
                    {
                        if (list.Set[i].Count > j)
                        {
                            this.x = i;
                            this.y = j;
                            return true;
                        }
                    }
                }
                else
                {
                    for (int j = y + 1; j < list.Set[i].Count; j++)
                    {
                        if (list.Set[i].Count > j)
                        {
                            this.x = i;
                            this.y = j;
                            return true;
                        }
                    }
                }

            }
            return false;
        }


        public bool MoveNext()
        {
            if (x == fx && y == fy)
            {
                fx = -1;
                return true;
            }
            return FindNext(x, y);
        }

        public void Reset()
        {
            x = fx;
            y = fy;
        }
    }
}
