using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MorozovSM.Sprint6.Task4.V5.Lib
{
    public class DataService : ISprint6Task4V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int ind = 0;
            double[] array = new double[stopValue-startValue+1];
            for (int i = startValue; i <= stopValue; i++) 
            {
                array[ind++] = double.Round((2*Math.Sin(i)/(3*i+1.2)) + Math.Cos(i) - 14*i, 2);
            }
            return array;
        }
    }
}
