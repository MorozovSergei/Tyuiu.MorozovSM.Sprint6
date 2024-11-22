using Tyuiu.MorozovSM.Sprint6.Task6.V29.Lib;

namespace Tyuiu.MorozovSM.Sprint6.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\necar\Downloads\InPutDataFileTask6V29.txt";
            var res = ds.CollectTextFromFile(path);
            string wait = "gMxrJi rvzAEwiXzIsLRa xakZKciG";
            Assert.AreEqual(wait, res);
        }
    }
}