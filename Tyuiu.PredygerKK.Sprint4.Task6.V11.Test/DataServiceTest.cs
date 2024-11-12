using Tyuiu.PredygerKK.Sprint4.Task6.V11.Lib;

namespace Tyuiu.PredygerKK.Sprint4.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            string[] array = { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            int expect = 3;
            Assert.AreEqual(expect, ds.Calculate(array));
        }
    }
}