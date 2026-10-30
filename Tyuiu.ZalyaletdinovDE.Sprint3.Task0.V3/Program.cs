using Tyuiu.ZalyaletdinovDE.Sprint3.Task0.V3.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.Write("Старт шага: ");
            int start = 1;
            Console.Write("Конец шага: ");
            int end = 10;

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("Y = " + ds.GetSumSeries(start, end));
        }
    }
}
