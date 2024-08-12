namespace Practice3.Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Роман", 30);
            student.Grade = 3;
            student.PrintStrudent();
            

        }
    }

    public class Student
    {
        private string _name;
        private int _age;
        private double _grade;

        public Student(string _name, int _age)
        {
            this._name = _name;

            this._age = _age;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }



        public double Grade
        {
            get { return _grade; }
            set
            {
                if (value > 0 && value <= 5)
                {
                    _grade = value;
                }
                else
                {
                    throw new ArgumentException("Оценка должна быть в диапазоне от 0 до 5");
                }
            }
        }

        public void PrintStrudent()
        {
            Console.WriteLine($"Имя студента: {_name}\nВозраст студента: {_age}\nОценка студента: {_grade}");
        }

    }
}
