using System;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = PointFactory.NewCartesianPoint(10, 20);
            Point b = PointFactory.NewPolarPoint(Math.Sqrt(2), 45);

            
            
        }
    }
}
