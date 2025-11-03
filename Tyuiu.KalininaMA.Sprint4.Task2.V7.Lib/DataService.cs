using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KalininaMA.Sprint4.Task2.V7.Lib
{
    public class DataService : ISprint4Task2V7
    {
        public int Calculate(int[] array)
        {
            int suArray = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    suArray += array[i];
                }
            }
            return suArray;
        }
    }
}
