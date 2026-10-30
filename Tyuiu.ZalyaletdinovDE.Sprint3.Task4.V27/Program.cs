using Tyuiu.ZalyaletdinovDE.Sprint3.Task4.V27.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Шаг начала: " + start);
            Console.WriteLine("Шаг конца: " + end);

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("sum = " + ds.Calculate(start, end));
        }
    }
}
