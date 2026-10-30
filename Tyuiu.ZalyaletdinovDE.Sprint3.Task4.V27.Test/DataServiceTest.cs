using Tyuiu.ZalyaletdinovDE.Sprint3.Task4.V27.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int start = 1;
            int end = 3;
            double res = ds.Calculate(start, end);
            Assert.AreEqual(1.245, res);
        }
    }
}
