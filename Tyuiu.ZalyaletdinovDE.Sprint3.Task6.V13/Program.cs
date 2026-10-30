using Tyuiu.ZalyaletdinovDE.Sprint3.Task6.V13.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int start = 8;
            int end = 17;

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Отрезок: [" + start + ";" + end + "]");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("sum = " + ds.GetSumTheDivisors(start, end));
        }
    }
}
