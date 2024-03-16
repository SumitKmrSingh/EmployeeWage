using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class MonthlyWage
    {
        public MonthlyWage() {
            Console.Write("How many month you have work ? ");
            int totalMonth = Convert.ToInt32(Console.ReadLine());
            int totalWage = (20 * totalMonth) * 160;
            Console.WriteLine("Your Total Monthly Wage : " + totalWage);
        }
    }
}
