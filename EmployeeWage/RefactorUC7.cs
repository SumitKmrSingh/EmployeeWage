using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class RefactorUC7 
    {
        public void getRefactor() 
        {
            EmployeeWage employeeWage = new EmployeeWage();
            Console.WriteLine(employeeWage.getEmployeDailyWage());
        }
    }
}
