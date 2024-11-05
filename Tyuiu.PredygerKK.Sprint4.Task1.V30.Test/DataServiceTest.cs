using Tyuiu.PredygerKK.Sprint4.Task1.V30.Lib;

namespace Tyuiu.PredygerKK.Sprint4.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int except = 13824;
            int[] array = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            array[0] = 6;
            array[1] = 7;
            array[2] = 8;
            array[3] = 7;
            array[4] = 6;
            array[5] = 5;
            array[6] = 6;
            array[7] = 9;
            array[8] = 9;
            array[9] = 5;
            array[10] = 7;
            array[11] = 9;
            array[12] = 7;
            array[13] = 8;
            array[14] = 7;

            Assert.AreEqual(except, ds.Calculate(array));
        }
    }
}