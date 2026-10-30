using Tyuiu.ZalyaletdinovDE.Sprint3.Task3.V15.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();
            string str = "ffmmf ffmff gmgsfmmmsa";
            char ch = 'm';
            int res = ds.GetMinCharCount(str, ch);
            Assert.AreEqual(1, res);
        }
    }
}
