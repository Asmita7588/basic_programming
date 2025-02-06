using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicProgramming.oopsProgramming
{
    internal class Circle :Shape
    {
        public void GetArea()
        {
            double radius = 2.3;
            double areaOfCircle = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Area Of Circle = " +areaOfCircle);

        }
    }
}
