using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GulahmedovTE.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            switch (n)
            {
                case 1 when m == 1:
                    n = 31;
                    m = 12;
                    g--;
                    break;
                case 1:
                    m--;
                    switch (m)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                            n = 31;
                            break;
                        case 2:
                            n = 29;
                            break;
                        default:
                            n = 30;
                            break;
                    }
                    break;
                default:
                    if (n < 1 || n > 31)
                    {
                        return $"Количество дней должно быть от 1 до 31. Значение {n}";
                    }
                    else
                        n--;
                    break;
            }

            return $"{n:D2}.{m:D2}.{g}";
        }
    }
}