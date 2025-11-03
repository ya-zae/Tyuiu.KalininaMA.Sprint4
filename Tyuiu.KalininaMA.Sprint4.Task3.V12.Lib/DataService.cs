using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KalininaMA.Sprint4.Task3.V12.Lib
{
    public class DataService : ISprint4Task3V12
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1; 
            int colums = array.Length / rows; 

            int min = array[0, 2];

            for (int i = 0; i < rows; i++)
            {
                if (array[i, 2] < min)
                {
                    min = array[i, 2];
                }
            }
            return min;
        }
    }
}
