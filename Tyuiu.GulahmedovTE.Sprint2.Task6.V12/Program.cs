using Tyuiu.GulahmedovTE.Sprint2.Task6.V12.Lib;
namespace Tyuiu.GulahmedovTE.Sprint2.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной StartYear, n");
            int startYear, n;
            startYear = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("StartYear: " + startYear + " " + "n: " + n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.FindMonthName(startYear, n);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}