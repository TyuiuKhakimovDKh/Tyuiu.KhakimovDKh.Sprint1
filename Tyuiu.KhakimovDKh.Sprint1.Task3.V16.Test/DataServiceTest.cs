using Tyuiu.KhakimovDKh.Sprint1.Task3.V16.Lib;
namespace Tyuiu.KhakimovDKh.Sprint1.Task3.V16.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 3.0;
            double x2 = -2.0;

            var res = ds.CoeffOfQuadraticEquation( x1, x2);
            Assert.AreEqual( -1.0, res);
        }
    }
}