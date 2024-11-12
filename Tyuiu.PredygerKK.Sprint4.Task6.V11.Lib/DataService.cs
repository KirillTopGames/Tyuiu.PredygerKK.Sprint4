using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PredygerKK.Sprint4.Task6.V11.Lib
{
    public class DataService : ISprint4Task6V11
    {
        public int Calculate(string[] array)
        {
            int res = 0;
            foreach (string element in array)
            {
                if(element.Length == 5)
                {
                    res += 1;
                }
            }
            return res;
        }
    }
}
