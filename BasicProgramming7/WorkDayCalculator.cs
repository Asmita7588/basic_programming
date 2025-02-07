using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming7
{
    internal class WorkDayCalculator
    {
        public int CalculateWorkDay() {

            Console.Write("Enter Start Date in this Format (YYYY - MM - DD): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter End Date in this Format (YYYY - MM - DD): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            int workDay = 0;
            if(startDate > endDate)
            {
                Console.WriteLine("Start date should be greater than End Date");

            }
            while(startDate <= endDate)
            {
                if(startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Saturday)
                {
                    workDay++;
                }
                startDate = startDate.AddDays(1);

            }
            return workDay;
        }
    }
}
