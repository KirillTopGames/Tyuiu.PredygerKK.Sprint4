using Tyuiu.PredygerKK.Sprint4.Task6.V11.Lib;

namespace Tyuiu.PredygerKK.Sprint4.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Предыгер К.К. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Предыгер Кирилл Константинович | ПКТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Кошка\", \"Собака\", \"Слон\", \"Жираф\",*");
            Console.WriteLine("*  \"Бегемот\", \"Игуана\", \"Ягуар\"] используя класс Array подсчитайте  *");
            Console.WriteLine("* количество элементов, длина которых равна 5.                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Исходный строковый массив:");
            string[] array = { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            foreach (string element in array)
            {
                if (element.Length > 0)
                {
                    Console.WriteLine(element, "\a");
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Кол-во элементов длины 5:");
            Console.WriteLine(ds.Calculate(array));
        }
    }
}
