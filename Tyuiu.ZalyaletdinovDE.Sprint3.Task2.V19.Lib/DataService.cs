using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task2.V19.Lib
{
    public class DataService : ISprint3Task2V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double s = 0;
            int i = startValue;
            do
            {
                s += Math.Cos(i) / 2;
                i++;
            } while (i < stopValue + 1);
            return Math.Round(s, 3);
        }
    }
}
