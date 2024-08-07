//Создай класс "Студент" с полями "Имя" и "Возраст". Напиши метод, который будет
//выводить информацию о студенте в консоль.


namespace Practice3.Task1
{
    public class Program
    {


        static void Main(string[] args)
        {
            Student student = new Student("Роман", 30);

            student.PrintStrudent();
        }
    }

    public class Student
    {
        private string _name;

        private int _age;

        public Student(string _name, int _age)
        {
            this._name = _name;

            this._age = _age;
        }

        public void PrintStrudent()
        {
            Console.WriteLine($"Имя студента: {_name}\nВозраст студента: {_age}");
        }


    }
}
