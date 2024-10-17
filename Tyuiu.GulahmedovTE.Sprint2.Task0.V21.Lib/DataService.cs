using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GulahmedovTE.Sprint2.Task0.V21.Lib
{
    public class DataService : ISprint2Task0V21
    {
        public bool[] GetCompareOperations(int x, int y)
        {

            // y = 775 x = 1705
            bool[] res = new bool[6];
            res[0] = y - 930 == x;
            res[1] = y + 930 != x;
            res[2] = x < y;
            res[3] = y - 2000 > x;
            res[4] = x <= y;
            res[5] = y - 1900 >= x;
            return res;
        }
    }
}