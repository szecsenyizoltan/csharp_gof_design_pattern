using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public static class PointFactory
    {
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point()
            {
                X = x,
                Y = y
            };
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point()
            {
                X = rho * Math.Sin(theta * Math.PI / 180),
                Y = rho * Math.Cos(theta * Math.PI / 180)
            };
        }
    }
}
