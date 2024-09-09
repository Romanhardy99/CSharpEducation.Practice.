using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Practice5.Task2;

namespace Practice5.Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region initObject

            Employee employee = new Employee("Роман", 50000);
            Manager employeeM = new Manager("Роман", 50000, 5);
            EmployeeList employeeList = new EmployeeList();
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger fileLogger = new FileLogger("logText.txt");

            #endregion

            #region  addObject

            employeeList.AddEmployee(new Employee("Егор", 100000));
            employeeList.AddEmployee(new Manager("Макс", 70000, 6));
            employeeList.AddEmployee(new Contractor("Роман", 100));

            #endregion

            #region Method

            Console.Write("Таск 1.a - 10 % от зп:\t");
            Console.Write(employee.CalculateBonus());
            Console.WriteLine();

            Console.Write("Таск 1.b - 20% от зп:\t");
            Console.Write(employeeM.CalculateBonus());
            Console.WriteLine();

            Console.WriteLine("Таск 1.c: ");
            Console.Write("Введите количество отработанных часов: ");

            string hourWorkedInput = Console.ReadLine();

            if (!int.TryParse(hourWorkedInput, out int hoursWorked))
            {
                Console.WriteLine("Ошибка");
                return;
            }

            employeeList.CalculateHours(hoursWorked);

            #endregion

            #region Logg

            consoleLogger.Trace("Это Trace");

            fileLogger.Error("Это Error");

            #endregion
        }
    }
}
