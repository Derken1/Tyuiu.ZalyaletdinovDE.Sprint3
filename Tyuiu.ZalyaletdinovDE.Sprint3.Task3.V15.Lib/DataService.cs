using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            int min = int.MaxValue;
            int count = 0;
            foreach (char c in value)
            {
                if (c == item)
                {
                    count++;
                } else
                {
                    if (count > 0)
                    {
                        min = Math.Min(min, count);
                    }
                    count = 0;
                }

            }
            if (count > 0)
            {
                min = Math.Min(min, count);
            }
            return min == int.MaxValue ? 0 : min;
        }
    }
}
