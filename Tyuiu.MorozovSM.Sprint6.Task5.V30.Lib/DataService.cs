using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MorozovSM.Sprint6.Task5.V30.Lib
{
    public class DataService : ISprint6Task5V30
    {
        public double[] LoadFromDataFile(string path)
        {
            string line;
            double[] retArray;
            int len = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (2 <= Convert.ToDouble(line) && Convert.ToDouble(line) <= 7) len++;
                }
                retArray = new double[len];
            }
            int ind = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (2 <= Convert.ToDouble(line) && Convert.ToDouble(line) <= 7) retArray[ind++] = Convert.ToDouble(line);
                }
            }
            return retArray;
        }
    }
}
