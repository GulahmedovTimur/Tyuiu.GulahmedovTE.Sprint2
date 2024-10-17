using Tyuiu.GulahmedovTE.Sprint2.Task0.V21.Lib;
namespace Tyuiu.GulahmedovTE.Sprint2.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareoperations()
        {

            DataService ds = new DataService();
            int x = 1705;
            int y = 775;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, false, false, false, false, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}