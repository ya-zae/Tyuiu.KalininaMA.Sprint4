using Tyuiu.KalininaMA.Sprint4.Task6.V30.Lib;

namespace Tyuiu.KalininaMA.Sprint4.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculatePositiveCount()
        {
            DataService ds = new DataService();
            string[] array = { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };

            string[] wait = { "Береза" };
            string[] result = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, result);
        }
    }
}
