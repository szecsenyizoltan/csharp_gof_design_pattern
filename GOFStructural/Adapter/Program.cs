using Adapter.Adapters;
using Adapter.DataSource;
using Adapter.DataVisualisation;
using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INameSource source = new NameRepository();
            NameVizualizer visualizer = new NameVizualizer(new NameSourceToNameDataAdapter(source));
            visualizer.Show();
            
        }
    }
}
