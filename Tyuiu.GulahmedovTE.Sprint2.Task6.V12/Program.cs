using Tyuiu.GulahmedovTE.Sprint2.Task6.V12.Lib;
namespace Tyuiu.GulahmedovTE.Sprint2.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Предыдущая дата: " + ds.FindDateOfPreviousDay(g, m, n));

            Console.ReadKey();
        }
    }
}