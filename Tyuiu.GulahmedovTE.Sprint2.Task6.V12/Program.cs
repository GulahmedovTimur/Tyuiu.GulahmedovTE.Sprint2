using Tyuiu.GulahmedovTE.Sprint2.Task6.V12.Lib;
namespace Tyuiu.GulahmedovTE.Sprint2.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int g, m, n;

            Console.WriteLine("Введите значение G: ");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение M: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение N: ");
            n = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfPreviousDay(g, m, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (((m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12) && (n < 1 || n > 31)) || ((m == 4 || m == 6 || m == 9 || m == 11) && (n < 1 || n > 30)) || (m == 29 && (n < 1 || n > 29)) || (m < 1 || m > 12))
            {
                Console.WriteLine("Введено неверное значение!");
            }
            else
            {
                Console.WriteLine(res);
            }


            Console.ReadKey();
        }
    }

}