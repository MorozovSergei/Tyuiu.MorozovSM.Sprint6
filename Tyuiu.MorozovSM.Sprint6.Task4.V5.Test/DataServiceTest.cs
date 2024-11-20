using Tyuiu.MorozovSM.Sprint6.Task4.V5.Lib;

namespace Tyuiu.MorozovSM.Sprint6.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            int start = -5;
            int end = -2;
            double[] array = ds.GetMassFunction(start, end);
            double[] wait = {70.14,55.21,41.05,27.96, };
            CollectionAssert.AreEqual(wait, array);
        }
    }
}