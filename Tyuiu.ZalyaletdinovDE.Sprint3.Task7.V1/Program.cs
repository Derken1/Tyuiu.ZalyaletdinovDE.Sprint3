using Tyuiu.ZalyaletdinovDE.Sprint3.Task7.V1.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Начало шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = stopValue - startValue + 1;

            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |    f(x)  |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len-1; i++)
            {
                Console.WriteLine("|{0,5:d}     |{1, 7:f2}   |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
        }
    }
}
