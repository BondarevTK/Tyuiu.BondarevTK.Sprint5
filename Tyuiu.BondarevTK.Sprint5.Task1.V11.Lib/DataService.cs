using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BondarevTK.Sprint5.Task1.V11.Lib
{
    public class DataService : ISprint5Task1V11
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempFileName();
            for (int x = startValue;  x <= stopValue; x++)
            {
                double res;
                if (3 * x - 1 == 0)
                {
                    res = 0;
                    File.AppendAllText(path, Convert.ToString(res));
                    continue;
                    
                }
                res = (Math.Sin(x) - 2 * x) / (3 * x - 1) + Math.Sin(x) - 3 * x + 2;
                File.AppendAllText(path,Convert.ToString(res) + Environment.NewLine);
            }
            return path;
        }
    }
}
