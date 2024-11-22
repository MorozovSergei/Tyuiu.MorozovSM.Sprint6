using Tyuiu.MorozovSM.Sprint6.Task5.V30.Lib;

namespace Tyuiu.MorozovSM.Sprint6.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\necar\Downloads\InPutDataFileTask5V30.txt";
            var array = ds.LoadFromDataFile(path);
            double[] wait = { 5 };
            CollectionAssert.AreEqual(wait, array);
        }
    }
}