using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloMethod1
{
    struct Coordinates
    {
        private double x, y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Coordinates(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Coordinates(Random Object)
        {
            this.x = Object.NextDouble();
            this.y = Object.NextDouble();

        }
        
        public double hypot(double x, double y)
        {
            return Math.Sqrt((x * x) + (y * y));
        }
    }

}
