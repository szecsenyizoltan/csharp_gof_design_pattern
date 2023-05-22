using Adapter.DataSource;
using Adapter.DataVisualisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapters
{
    internal class NameSourceToNameDataAdapter : INameData
    {
        private Queue<string> dataQueue;
        public Queue<string> DataQueue => dataQueue;

        public NameSourceToNameDataAdapter(INameSource source)
        {
            dataQueue = new Queue<string>();
            foreach (var item in source.Names)
            {
                dataQueue.Enqueue(item);
            }
        }
    }
}
