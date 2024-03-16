using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmployeeWage
    {
        public void getEmployeDailyWage()
        {
            Console.Write("Enter Total number of Working hour : ");
            int workingHour = Convert.ToInt32(Console.ReadLine());
            double totalDay = workingHour/ 8;
            int totalWage = 20*workingHour;
            Console.WriteLine("Total Working Day : "+totalDay);
            Console.WriteLine("Total Wage : "+totalDay);
        }
    }
}
