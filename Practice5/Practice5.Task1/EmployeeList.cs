using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1
{
    public class EmployeeList
    {
        /// <summary>
        /// Список сотрудников.
        /// </summary>
        List<Employee> employeeList = new List<Employee>();

        /// <summary>
        /// Метод добавления сотрудника в список.
        /// </summary>
        /// <param name="employee">объект сотрудника</param>
        public void AddEmployee(Employee employee)
        {
            employeeList.Add(employee);
        }

        /// <summary>
        /// Расчет бонуса в зависимости отработанных часов.
        /// </summary>
        /// <param name="hoursWorked">переменная отработки часов</param>
        public void CalculateHours(int hoursWorked)
        {
            foreach (var employee in employeeList)
            {
                if(employee is Contractor contractor)
                {
                    decimal contractorBonus = contractor.CalculateBonus(hoursWorked);
                    Console.WriteLine($"Сотруднику {contractor.Name} бонус за {hoursWorked} часов работы: {contractorBonus}");
                }
                else
                {
                    decimal bonus = employee.CalculateBonus();
                    Console.WriteLine($"Для сотрудников {employee.Name} бонус {bonus}");
                }
            }
        }


    }
}
