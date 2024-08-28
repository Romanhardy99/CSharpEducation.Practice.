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
            EmployeeList employeeList = new EmployeeList();
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger fileLogger = new FileLogger("logText.txt");

            employeeList.AddEmployee(new Employee("Егор", 100000));
            employeeList.AddEmployee(new Manager("Макс", 70000, 6));
            employeeList.AddEmployee(new Contractor("Роман", 100));

            Console.Write("Введите количество отработанных часов: ");

            string hourWorkedInput = Console.ReadLine();

            if (!int.TryParse(hourWorkedInput, out int hoursWorked))
            {
                Console.WriteLine("Ошибка");
                return;
            }

            employeeList.CalculateHours(hoursWorked);

            consoleLogger.Trace("Это Trace");

            fileLogger.Error("Это Error");
        }
    }
}
