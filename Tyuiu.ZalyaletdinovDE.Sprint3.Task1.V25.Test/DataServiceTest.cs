using Tyuiu.ZalyaletdinovDE.Sprint3.Task1.V25.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int num = 2;
            int start = 1;
            int end = 3;
            double res = ds.GetMultiplySeries(num , start, end);
            Assert.AreEqual(1.161, res);
        }
    }
}
