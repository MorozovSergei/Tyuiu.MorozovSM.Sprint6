using Tyuiu.MorozovSM.Sprint6.Task0.V5.Lib;

namespace Tyuiu.MorozovSM.Sprint6.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            int x = 5;
            double wait = -114.5;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}