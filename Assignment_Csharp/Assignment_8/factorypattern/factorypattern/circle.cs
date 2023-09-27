using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Circle : IShape
    {
        public double r = 3;
        public double GetCircumference()
        {
            return Math.PI*2*r;
        }

        public double GetArea()
        {
            return Math.PI*r*r;
        }

        public string ShapeType()
        {
            return "Circle";
        }
    }
}