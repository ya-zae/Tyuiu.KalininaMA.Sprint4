using Tyuiu.KalininaMA.Sprint4.Task2.V7.Lib;
namespace Tyuiu.KalininaMA.Sprint4.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = {5, 5, 5, 4, 4, 6, 5, 4, 5, 5, 4, 4 };

            int res = ds.Calculate(array);
            int wait = 26;
            Assert.AreEqual(wait, res);


        }
    }
}
