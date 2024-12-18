using Tyuiu.BondarevTK.Sprint5.Task1.V11.Lib;
namespace Tyuiu.BondarevTK.Sprint5.Task1.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = -5;
            int y = 5;
            string res = ds.SaveToFileTextData(x, y);
            StreamReader sr = new StreamReader(res);
            string line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
        }
    }
}
