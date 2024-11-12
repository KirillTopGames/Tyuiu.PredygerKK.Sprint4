using Tyuiu.PredygerKK.Sprint4.Task7.V19.Lib;

namespace Tyuiu.PredygerKK.Sprint4.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();

            string value = "90817264";
            int n = 4;
            int m = 2;
            int expect = 3;

            Assert.AreEqual(expect, ds.Calculate(n, m, value));
        }
    }
}