using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BondarevTK.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] strings = text.Split(",");
            double res = 1;
            foreach (string s in strings)
            {
                if (int.TryParse(s.Trim(), out int number) && number > 9 && number < 100)
                {
                    res *= number;
                }
            }
            return res;
        }
    }
}
