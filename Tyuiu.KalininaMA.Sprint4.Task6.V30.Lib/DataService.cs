using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KalininaMA.Sprint4.Task6.V30.Lib
{
    public class DataService : ISprint4Task6V30
    {
        public string[] Calculate(string[] array)
        {
            var metod = array.Where(element => element.Length > 5).ToArray();
            return metod;

    }
    }
}
