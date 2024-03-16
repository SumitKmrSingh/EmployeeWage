using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmployeeWagePartTime
    {
        public void getPartTimeWage()
        {
            Console.Write("Enter total Part time Working hour : ");
            int workingHour = Convert.ToInt32(Console.ReadLine());
     
            int totalWage = 20 * workingHour;
            Console.WriteLine("Total Wage : " + totalWage);
        }
    }
}
