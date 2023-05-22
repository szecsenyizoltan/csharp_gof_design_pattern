using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DataVisualisation
{
    internal interface INameData
    {
        public Queue<string> DataQueue { get; }
    }
}
