using Tyuiu.PredygerKK.Sprint4.Task4.V23.Lib;

namespace Tyuiu.PredygerKK.Sprint4.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int[,] matrix = { { 8,7,5,8,7 },
                              { 8,3,3,6,4 },
                              { 4,4,5,5,4 },
                              { 3,4,7,7,3 },
                              { 6,8,3,6,7 } };

            int expect = 65;
            Assert.AreEqual(expect, ds.Calculate(matrix));
        }
    }
}