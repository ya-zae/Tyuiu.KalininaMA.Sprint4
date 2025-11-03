using Tyuiu.KalininaMA.Sprint4.Task0.V2.Lib;
namespace Tyuiu.KalininaMA.Sprint4.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int res =  ds.GetSumOddArrEl(array);
            int wait = 44;
            Assert.AreEqual(wait, res);
        }
    }
}
