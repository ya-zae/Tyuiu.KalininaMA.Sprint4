using Tyuiu.KalininaMA.Sprint4.Task1.V28.Lib;
namespace Tyuiu.KalininaMA.Sprint4.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = {2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4  };

            int res = ds.Calculate(array);
            int wait = 375;
            Assert.AreEqual(wait, res);


        }
    }
}
