using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Of_December
{
    public class A
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
    }
    class Circle2 : A
    {
        public double Radius { get; set; }

        public Circle2(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        



    }
}
