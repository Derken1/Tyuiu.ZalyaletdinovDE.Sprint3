using Tyuiu.ZalyaletdinovDE.Sprint3.Task3.V15.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint3.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string str = "lrmmse mg sermmmrt";
            char ch = 'm';

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Строка: " + str);
            Console.WriteLine("Символ: " + ch);

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("min = " + ds.GetMinCharCount(str, ch));
        }
    }
}
