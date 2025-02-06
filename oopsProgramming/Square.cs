using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace basicProgramming.oopsProgramming
{
    internal class Square :Shape
    {
        public void GetArea()
        {
            double sides = 2.3;
            double areaOfSquare = sides * sides;
            Console.WriteLine("Area Of square = " + areaOfSquare);
        }
    }
}
