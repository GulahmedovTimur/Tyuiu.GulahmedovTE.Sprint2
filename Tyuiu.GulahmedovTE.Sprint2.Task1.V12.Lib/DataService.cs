using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GulahmedovTE.Sprint2.Task1.V12.Lib
{
    public class DataService : ISprint2Task1V12
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b)  | (c < d); //t
            res[1] = (b + 1000 > c) & (a < d); //t
            res[2] = (a > b) || (c < d); //t
            res[3] = (b - 1000 > c) & (d < a); //f
            res[4] = !(!res[0]); //t
            res[5] = (a < b) ^ (c < d); //f

            return res;
        }
    }
}
