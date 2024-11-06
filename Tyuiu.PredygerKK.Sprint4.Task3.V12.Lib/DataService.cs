using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PredygerKK.Sprint4.Task3.V12.Lib
{
    public class DataService : ISprint4Task3V12
    {
        public int Calculate(int[,] array)
        {
            int min = 999;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == 2 && array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }
    }
}
