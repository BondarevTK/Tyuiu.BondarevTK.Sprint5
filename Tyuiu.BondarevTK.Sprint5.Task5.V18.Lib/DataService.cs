using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BondarevTK.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] strings = text.Split(" ");
            double res = 1;
            foreach (string s in strings)
            {
                if (Double.TryParse(s.Trim(), out double number) && Math.Abs(number) > 9 && Math.Abs(number) < 100)
                {
                    res = res * number;
                }
            }
            return res;
        }
    }
}
