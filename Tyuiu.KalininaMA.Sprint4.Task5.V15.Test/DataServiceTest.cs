using Tyuiu.KalininaMA.Sprint4.Task5.V15.Lib;
namespace Tyuiu.KalininaMA.Sprint4.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] a = { { -5, -6, -5, -6, -5 },
                { -5, -5, -5, -4, -4 },
                { -5, -5, -5, -4, -4 },
                { -6, 5, -4, 4, -8 },
                { -6, -5, -6, -4, -4 } };
            int res = ds.Calculate(a);
            int wait = 9;

            Assert.AreEqual(wait,res);
        }
    }
}
