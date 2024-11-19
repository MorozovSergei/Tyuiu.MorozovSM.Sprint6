using Tyuiu.MorozovSM.Sprint6.Task2.V11.Lib;

namespace Tyuiu.MorozovSM.Sprint6.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            int startValue = 1;
            int endValue = 2;
            double[] ResArray = ds.GetMassFunction(startValue, endValue);
            double[] wait = { 2.57, 6.4};
            CollectionAssert.AreEqual(ResArray, wait);
        }
    }
}