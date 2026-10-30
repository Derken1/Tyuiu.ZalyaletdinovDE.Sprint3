using Tyuiu.ZalyaletdinovDE.Sprint3.Task1.V25.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task1.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Число в основании");
            int a = 2;
            Console.Write("Старт шага: ");
            int start = 1;
            Console.Write("Конец шага: ");
            int end = 6;

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("p = " + ds.GetMultiplySeries(a, start, end));
        }
    }
}
