using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1
{
    public class Contractor : Employee
    {
        public decimal HourlyRate { get; set; } 

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name">Переменная имя.</param>
        /// <param name="hourlyRate">Переменная почасовая ставка.</param>
        public Contractor(string name, decimal hourlyRate) : base(name, 0)
        {
            HourlyRate = hourlyRate;
        }

        /// <summary>
        /// Расчитывает бонус отработанных часов сотрудника.
        /// </summary>
        /// <param name="hoursWorked"></param>
        /// <returns></returns>
        public decimal CalculateBonus(int hoursWorked)
        {
            return hoursWorked * HourlyRate;
        }

        public override decimal CalculateBonus()
        {
            throw new InvalidOperationException("Для подрядчиков используйте метод CalculateBonus(int hoursWorked).");
        }
    }
}
