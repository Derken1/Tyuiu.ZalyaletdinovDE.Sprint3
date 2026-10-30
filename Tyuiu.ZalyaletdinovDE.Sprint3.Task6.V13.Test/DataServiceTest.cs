using Tyuiu.ZalyaletdinovDE.Sprint3.Task6.V13.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int start = 8;
            int end = 10;
            int res = ds.GetSumTheDivisors(start, end);
            Assert.AreEqual(19, res);
        }
    }
}
