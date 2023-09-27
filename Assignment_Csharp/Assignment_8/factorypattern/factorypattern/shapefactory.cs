using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class CreditCardFactory
    {
        public static IShape ShapeType(string shapeType)
        {
            IShape Icc = null;
            if (shapeType == "Circle")
            {
                Icc = new Circle();
            }
            else if (shapeType == "Triangle")
            {
                Icc = new triangle();
            }
            else if (shapeType == "Reactangle")
            {
                Icc = new Rectangle();
            }
            return Icc;
        }
    }
}