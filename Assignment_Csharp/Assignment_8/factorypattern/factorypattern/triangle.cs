using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class triangle: IShape
    {
        int a = 2, b = 6, c = 7;
        int breadth = 8;
        int height = 9;
        public double GetCircumference()
        {
            return a+b+c;
        }

        public double GetArea()
        {
            return (0.5)*breadth*height;
        }

        public string ShapeType()
        {
            return "Triangle";
        }
    }
}