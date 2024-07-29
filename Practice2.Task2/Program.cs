using System.Xml.Serialization;

namespace Practice2.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program value = new Program();
            value.Kilometr();
            value.Santimetr();
            value.KmSecond();
            value.Temp();
        }

        void Kilometr()
        {
            double metr = 120;

            double km = metr / 1000;

            Console.WriteLine($"{metr} метров равно {km} километров\t");

        }

        void Santimetr()
        {
            double km = 1000;

            double sm = km / 100000;

            Console.WriteLine($"В {km} километре {sm} сантиметров\t");
        }
        void KmSecond()
        {
            double MetrScond = 20;

            double KilometrHour = MetrScond * 3.6;

            Console.WriteLine($"В {MetrScond} м/с будет равно {KilometrHour} км/ч \t");
        }

        void Temp()
        {
            int celcius = -15;

            int fahrenheit = celcius * 9 / 5 + 35;

            Console.WriteLine($"Температура в C: {celcius} будет равна {fahrenheit} F");
        }

    }
}
