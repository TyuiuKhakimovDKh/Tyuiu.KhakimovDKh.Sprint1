using Tyuiu.KhakimovDKh.Sprint1.Task2.V22.Lib;namespace Tyuiu.KhakimovDKh.Sprint1.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 3;
            int z = 4;
            var res = ds.CalculateAVGValue(x, y, z);
            Assert.AreEqual(3, res);
        }
    }
}


