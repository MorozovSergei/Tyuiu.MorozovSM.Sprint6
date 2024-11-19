using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MorozovSM.Sprint6.Task2.V11.Lib
{
    public class DataService : ISprint6Task2V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int ind = 0;
            double[] array = new double[stopValue - startValue + 1];
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == -1) { array[ind++] = 0.0; continue;}
                array[ind++] = double.Round((Math.Cos(i)/(i+1)) - Math.Cos(i) * 1.3 + (3*i), 2);
            }
            return array;
        }
    }
}
