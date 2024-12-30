using Tyuiu.KhakimovDKh.Sprint1.Task5.V6.Lib;
namespace Tyuiu.KhakimovDKh.Sprint1.Task5.V6.Test
{

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            var dataService = new DataService();
            Assert.AreEqual(7, dataService.Calculate(35));
        }
    }
}
