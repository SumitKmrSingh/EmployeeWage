using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class SwitchCaseUC4
    {
        public void getEmployeeInfo()
        {
            while(true)
            {
                Console.WriteLine("1. Employee Attendance");
                Console.WriteLine("2. Employee Wage");
                Console.WriteLine("3. Part time Employee & Wage");
                Console.WriteLine("4. Month Wages");
                Console.WriteLine("5. Calculate Wages till a condition of total nworking hours " +
                    "or days is reached for");
                Console.WriteLine("6. Exit");

                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                            // Creating object of EmployeAttendence Class
                            EmployeAttendence employeAttendence = new EmployeAttendence();
                            employeAttendence.getEmployeeAttendence();
                            break;
                     
                    case 2:
                            // Creating object of EmployeeWage Class
                            EmployeeWage employeeWage = new EmployeeWage();
                            break;

                    case 3: // Creating object of EmployeeWagePartTime Class
                            EmployeeWagePartTime employeeWagePartTime = new EmployeeWagePartTime();
                            employeeWagePartTime.getPartTimeWage();
                            break;

                    case 4:
                            // Creating object of MonthlyWage Class
                            MonthlyWage monthlyWage = new MonthlyWage();
                            break ;

                    case 5:
                            // Creating object of CalulateWageUC6 Class UC5
                            CalulateWageUC6 calulateWageUC6 = new CalulateWageUC6();
                            break;

                    case 6:
                            return;

                    default:
                            Console.WriteLine("Invalid Choice");
                            break;
                }
            }
        }
    }
}
