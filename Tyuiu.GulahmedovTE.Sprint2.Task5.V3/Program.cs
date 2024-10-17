using Tyuiu.GulahmedovTE.Sprint2.Task5.V3.Lib;
namespace Tyuiu.GulahmedovTE.Sprint2.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Введите  порядковый номер дня недели: ");
            int x = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((x < 1) || (x > 7))
            {
                res = "Неверно введен номер дня недели";
            }
            else
            {
                res = "Это " + ds.FindDayName(x);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
        }
    }
}
