using Tyuiu.PredygerKK.Sprint4.Task7.V19.Lib;

namespace Tyuiu.PredygerKK.Sprint4.Task7.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Предыгер К.К. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Предыгер Кирилл Константинович | ПКТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 90817264. Преобразуйте ее в матрицу   *");
            Console.WriteLine("* 4 на 2 и подсчитайте количество нечетных чисел в матрице.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите число строк матрицы:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число столбцов матрицы:");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, m];

            Console.WriteLine("Введите строку из одноразрядных цифр:");
            string value = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Строка:"+value);
            Console.WriteLine("Матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[i * m + j]} \t");
                }
                Console.WriteLine();

            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Кол-во нечётных элементов:");
            Console.WriteLine(ds.Calculate(n, m, value));
        }
    }
}
