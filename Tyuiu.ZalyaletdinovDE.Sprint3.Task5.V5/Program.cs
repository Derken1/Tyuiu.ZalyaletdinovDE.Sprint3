using Tyuiu.ZalyaletdinovDE.Sprint3.Task5.V5.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 5;
            int start1 = 1;
            int start2 = 1;
            int end1 = 3;
            int end2 = 10;

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Шаг начала первого цикла: " + start1);
            Console.WriteLine("Шаг начала второго цикла: " + start2);
            Console.WriteLine("Шаг конца первого цикла: " + end1);
            Console.WriteLine("Шаг конца второго цикла: " + end2);
            Console.WriteLine("X = " + x);

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("sum = " + ds.GetSumSumSeries(x, start1, start2, end1, end2));
        }
    }
}
