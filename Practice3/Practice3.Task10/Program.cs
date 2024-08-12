//Создай класс "Автомобиль" с полем "Марка". Напиши метод, который будет
//принимать объект класса "Автомобиль" и выводить информацию о марке
//автомобиля в консоль

namespace Practice3.Task10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();

            string auto1 = auto.MethodMarka();            

            Console.WriteLine($"Марка машины: {auto1}");
        }
    }

    public class Auto
    {
        string Marka { get; set; }

        public Auto()
        {
            Marka = "Ауди";
        }

        public string MethodMarka()
        {
            return Marka;
        }

    }
}
