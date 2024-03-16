using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmployeAttendence
    {
        public void getEmployeeAttendence()
        {
            Random random = new Random();
            int present = random.Next(0, 2);
            if(present == 1) {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
        }
    }
}
