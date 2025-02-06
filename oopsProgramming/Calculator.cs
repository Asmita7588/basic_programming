using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicProgramming.oopsProgramming
{
    internal class Calculator
    {
        public void add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        public void add(double a, double b, double c){
            double result = a + b + c;
            Console.WriteLine(result);
        }


    }
}
