using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming7
{
    internal class FindPerfectSquare
    {
        public void PerfectSquare(int number)
        {
            if (number < 0)
                return;
            int squareRoot = (int)Math.Sqrt(number);
            int perfectSquare = squareRoot * squareRoot;

            if (number == perfectSquare)
                Console.WriteLine(number + " is a perfect Square Number");
            else Console.WriteLine(number + " is not a perfect Square Number");

        }
    }
}
