using Tyuiu.PredygerKK.Sprint4.Task0.V26.Lib;

namespace Tyuiu.PredygerKK.Sprint4.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();

            int[] array = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            int except = 41;
            Assert.AreEqual(ds.GetSumOddArrEl(array), except);
        }
    }
}