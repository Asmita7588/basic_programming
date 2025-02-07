using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming7
{
    internal class SumOddEvenOfIntegerNumber
    {
        public void SumOddEven(int n)
        {
           int sumOfEven = 0,  sumOfOdd = 0;
            while (n != 0)
            {
                int digit = n % 10;
                if (digit % 2 == 0)
                {
                    sumOfEven += digit;
                }
                else
                {
                    sumOfOdd += digit;
                }
                n /= 10;
            }
            Console.WriteLine("Sum of Even Digit = " +sumOfEven);
            Console.WriteLine("Sum of Odd Digit = " + sumOfOdd);


        }
    }
}
