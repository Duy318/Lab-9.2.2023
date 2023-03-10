using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        abstract public double CalculateArea();
        abstract public double CalculatePerimeter();
        public virtual string Draw()
        {
            return $"Drawing";
        }
    }

}