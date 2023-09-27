using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Rectangle : IShape
    {
        public double length = 2;
        public double width = 3;
        public double GetCircumference()
        {
            return 2*(length+width);
        }

        public double GetArea()
        {
            return length*width;
        }

        public string ShapeType()
        {
            return "Rectangle";
        }
    }
}