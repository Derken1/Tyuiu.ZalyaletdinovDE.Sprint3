using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task0.V3.Lib
{
    public class DataService : ISprint3Task0V3
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double s = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                s += Math.Sin(i) / 4;
            }
            return Math.Round(s, 3);
        }
    }
}
