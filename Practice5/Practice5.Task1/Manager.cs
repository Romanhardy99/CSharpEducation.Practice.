using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1
{
    public class Manager : Employee
    {
        public int TeamSize { get; set; }

        //переопределяет метод calculatebonus и возрвщает 20% от зп
        public Manager(string name, int salary, int teamSize) : base(name, salary) { TeamSize = teamSize; }

        /// <summary>
        /// Калькулятор бонуса от зп.
        /// </summary>
        /// <returns>Возвращает 20% от зп, и 25% если сотрудников больше 5</returns>
        public override decimal CalculateBonus()
        {
            decimal percent = 20;

            decimal percentBonus = 0;

            if (TeamSize > 5)
            {
                Console.WriteLine("Сотруднику бонус увеличен на 5%");
                percentBonus = 5;
            }

            decimal amount = percent + percentBonus;
                        
            return Salary * (amount / 100);
        }
    }
}
