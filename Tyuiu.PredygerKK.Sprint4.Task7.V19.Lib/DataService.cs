using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PredygerKK.Sprint4.Task7.V19.Lib
{
    public class DataService : ISprint4Task7V19
    {
        public int Calculate(int n, int m, string value)
        {
            int count = 0;
            int[,] matrix = new int[n, m];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(value[i * m + j].ToString());
                    if (matrix[i, j] % 2 != 0)
                    {
                        count += 1;
                    }
                }
            }
            return count;
        }
    }
}
