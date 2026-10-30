using Tyuiu.ZalyaletdinovDE.Sprint3.Task5.V5.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 3;
            int start1 = 1;
            int start2 = 1;
            int end1 = 3;
            int end2 = 10;
            double res = ds.GetSumSumSeries(x, start1, start2, end1, end2);
            Assert.AreEqual(58.972, res);
        }
    }
}
