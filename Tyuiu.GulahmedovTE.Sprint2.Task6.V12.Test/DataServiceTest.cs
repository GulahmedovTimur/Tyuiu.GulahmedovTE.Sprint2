using Tyuiu.GulahmedovTE.Sprint2.Task6.V12.Lib;
namespace Tyuiu.GulahmedovTE.Sprint2.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("04.04.2023", ds.FindDateOfPreviousDay(2023, 4, 5));
            Assert.AreEqual("31.12.2021", ds.FindDateOfPreviousDay(2022, 1, 1));
            Assert.AreEqual("10.10.2023", ds.FindDateOfPreviousDay(2023, 10, 11));
            Assert.AreEqual("30.11.1999", ds.FindDateOfPreviousDay(1999, 12, 1));
        }
    }
}