using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MorozovSM.Sprint6.Task1.V3.Lib
{
    public class DataService : ISprint6Task1V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int ind = 0;
            double[] array = new double[stopValue-startValue+1];
            for (int i = startValue; i <= stopValue; i++)
            {
                array[ind] = double.Round(5 - (3 * i) + ((1 + Math.Sin(i)) / ((2 * i) - 0.5)),2);
                ind++;
            }
            return array;
        }
    }
}
