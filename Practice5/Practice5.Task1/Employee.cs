namespace Practice5.Task1
{
    public class Employee
    {
        public string Name { get; set; }

        public int Salary { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name">Переменная имя.</param>
        /// <param name="salary">Переменная зарплата.</param>
        public Employee(string name, int salary)
        {
            Name = name;

            Salary = salary;
        }

        /// <summary>
        /// Калькулятор бонуса зп.
        /// </summary>
        /// <returns>Возвращает 10% от зарплаты</returns>
        public virtual decimal CalculateBonus()
        {
            decimal percent = 10;

            decimal amount = Salary * (percent / 100);
            
            return amount;
        }
    }
}
