using Tyuiu.KalininaMA.Sprint4.Task4.V29.Lib;

namespace Tyuiu.KalininaMA.Sprint4.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateSumOfEvenElements()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5]
            {
                { 5, 6, 5, 6, 5 },
                { 5, 5, 5, 8, 4 },
                { 8, 5, 5, 8, 8 },
                { 6, 5, 4, 4, 8 },
                { 8, 5, 6, 8, 8 }
            };

            int res = ds.Calculate(matrix);
            int expected = 6 + 6 + 8 + 4 + 8 + 8 + 8 + 6 + 4 + 4 + 8 + 8 + 6 + 8 + 8;

            Assert.AreEqual(expected, res);


        }
    }
}
