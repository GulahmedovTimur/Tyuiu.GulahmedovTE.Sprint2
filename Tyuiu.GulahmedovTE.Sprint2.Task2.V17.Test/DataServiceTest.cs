using Tyuiu.GulahmedovTE.Sprint2.Task2.V17.Lib;
namespace Tyuiu.GulahmedovTE.Sprint2.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotUnShadedArea()
        {

            DataService ds = new DataService();

            int x = 5;
            int y = 5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}