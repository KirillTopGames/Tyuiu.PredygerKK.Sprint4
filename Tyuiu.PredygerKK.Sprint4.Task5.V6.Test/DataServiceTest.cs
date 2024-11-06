using Tyuiu.PredygerKK.Sprint4.Task5.V6.Lib;

namespace Tyuiu.PredygerKK.Sprint4.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();

            int[,] matrix = { { -3, 2, 2, 5, 4 },
                              { -1, -2, -2, 0, 3 },
                              { 0, 0, 0, -1, -2 },
                              { -3, -2, -1, 0, 1 },
                              { 5, 3, 4, 2, 1 }, };

            int[,] ex_matrix = { { -3, 1, 1, 1, 1 },
                                 { -1, -2, -2, 0, 1 },
                                 { 0, 0, 0, -1, -2 },
                                 { -3, -2, -1, 0, 1 },
                                 { 1, 1, 1, 1, 1 }, };

            CollectionAssert.AreEqual(ex_matrix, ds.Calculate(matrix));
        }
    }
}