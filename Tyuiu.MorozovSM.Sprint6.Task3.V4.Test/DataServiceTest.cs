using Tyuiu.MorozovSM.Sprint6.Task3.V4.Lib;

namespace Tyuiu.MorozovSM.Sprint6.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            int[,] mat = { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 6 }, { 3, 4, 5, 6, 7 } };
            mat = ds.Calculate(mat);
            int[,] wait = { { 1, 2, 3, 4, 5 }, { 1, 0, 3, 0, 0 }, { 3, 4, 5, 6, 7 } };
            CollectionAssert.AreEqual(wait, mat);
        }
    }
}