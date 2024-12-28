 using Tyuiu.KhakimovDKh.Sprint1.Task4.V20.Lib;
namespace Tyuiu.KhakimovDKh.Sprint1.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 1.0;
            double wait = 1.892;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait,Math.Round(res ,3));
        }
    }
}
