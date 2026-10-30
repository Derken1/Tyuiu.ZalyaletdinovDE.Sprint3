using Tyuiu.ZalyaletdinovDE.Sprint3.Task2.V19.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int start = 1;
            int end = 3;
            double res = ds.GetSumSeries(start, end);
            Assert.AreEqual(-0.433, res);
        }
    }
}
