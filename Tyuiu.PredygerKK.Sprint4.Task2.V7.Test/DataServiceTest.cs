using Tyuiu.PredygerKK.Sprint4.Task2.V7.Lib;

namespace Tyuiu.PredygerKK.Sprint4.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int except = 28;
            int[] array = { 4, 4, 8, 6, 7, 5, 9, 9, 7, 6, 7, 9 };
            Assert.AreEqual(except, ds.Calculate(array));
        }
    }
}