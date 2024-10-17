using Tyuiu.GulahmedovTE.Sprint2.Task4.V29.Lib;
namespace Tyuiu.GulahmedovTE.Sprint2.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 20;
            double res = ds.Calculate(x, y);
            double wait = 99.9;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 20;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 399.8;
            Assert.AreEqual(res, wait);
        }

    }
}