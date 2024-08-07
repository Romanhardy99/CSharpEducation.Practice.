namespace Practice3.Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
           
            Console.WriteLine("Калькулятор для расчёта операций");
            while (true)
            {
                char temp;
                
                while (true)
                {
                    Console.WriteLine("Выберите операцию (+ , - , * , / ): ");
                    temp = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (temp == '+' || temp == '-' || temp == '*' || temp == '/')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный символ. Пожалуйста, выберите правильную операцию.");
                    }
                }

                Console.WriteLine("Введите первое число: ");
                double firstNumber;
                while (!double.TryParse(Console.ReadLine(), out firstNumber))
                {
                    Console.WriteLine("Некорректное число");
                }

                Console.WriteLine("Введите второе число: ");
                double lastNumber; 
                while(!double.TryParse(Console.ReadLine(),out lastNumber))
                {
                    Console.WriteLine("Неккоректное число");
                }

                double result = 0;




                switch (temp)
                {
                    case '+':
                        result = calculator.Add(firstNumber, lastNumber);
                        break;
                    case '-':
                        result = calculator.Sub(firstNumber, lastNumber);
                        break;
                    case '*':
                        result = calculator.Mult(firstNumber, lastNumber);
                        break;
                    case '/':
                        result = calculator.Div(firstNumber, lastNumber);
                        break;

                }
                Console.WriteLine($"Результат вычислений: {result}");
            }
            
        }
    }
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Mult(double a, double b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Делить на ноль нельзья!");
            }
            return a / b;

        }
    }
}
