using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DataSource
{
    internal class NameRepository : INameSource
    {
        public string[] Names
        {
            get
            {
                return new string[] { "John", "Jack", "Jimmy", "Peter", "Tony", "Eric", "Victor" };
            }
        }
    }
}
