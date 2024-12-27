using Tyuiu.KhakimovDKh.Sprint1.Task2.V22.Lib;namespace Tyuiu.KhakimovDKh.Sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateSideSquareParallelepiped()
        {
            DataService ds = new DataService();
            int value = 2;
            int valueTwo = 2;
            int valueThree = 2;
            var res = ds.CalculateAVGValue(value, valueTwo, valueThree);
            Assert.AreEqual(2, res);
        }
    }
}


