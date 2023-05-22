using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DataVisualisation
{
    internal class NameVizualizer
    {
        INameData data;
        public NameVizualizer(INameData data)
        {
            this.data = data;
        }

        public void Show()
        {
            while (data.DataQueue.Count > 0)
            {
                Console.WriteLine("***" + data.DataQueue.Dequeue() + "***");
            }
        }
    }
}
