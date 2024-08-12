namespace Practice3.Part2.Task3.Lib
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "Роман";
            Age = 30;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }
    }
}
