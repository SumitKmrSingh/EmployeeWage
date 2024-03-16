using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class CalulateWageUC6
    {
        public void getTotalMonthlyWage() {
            Console.Write("Enter total Working hour : ");
            int totalHour = Convert.ToInt32(Console.ReadLine());

            if(totalHour < 100) {
                Console.WriteLine("We have not Completed total day In a month");
            }
            else
            {
                int totalWage = 20 * totalHour;
                Console.WriteLine("Total Wage : " + totalWage);
             }
        }
    }
}
