using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicProgramming.oopsProgramming
{
    internal class Payment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment is Processing ");
        }

    }
    class CreadiCardPayment : Payment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment by creadit card");
        }
    }

    class CashPayment : Payment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment by Cash");
        }
    }


}
