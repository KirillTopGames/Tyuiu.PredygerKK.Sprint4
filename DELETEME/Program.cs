﻿namespace DELETEME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "94521854";
            int count = 0;
            int[,] matrix = new int[4, 2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(value[i + j].ToString());
                    if (matrix[i, j] % 2 != 0)
                    {
                        count += 1;
                    }
                }
            }
            Console.WriteLine(count);


        }
    }
}
