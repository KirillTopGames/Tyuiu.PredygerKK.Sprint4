using Tyuiu.PredygerKK.Sprint4.Task1.V30.Lib;

namespace Tyuiu.PredygerKK.Sprint4.Task1.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Предыгер К.К. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Предыгер Кирилл Константинович | ПКТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 5 до 9 подсчитать произведение   *");
            Console.WriteLine("* четных элементов массива. С клавиатуры:                                 *");
            Console.WriteLine("*  6, 7, 8, 7, 6, 5, 6, 9, 9, 5, 7, 9, 7, 8, 7                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите 15 элементов массива:");
            for(int i = 0; i < 15; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(array));
        }
    }
}
