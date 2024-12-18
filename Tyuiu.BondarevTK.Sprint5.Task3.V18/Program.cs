using Tyuiu.BondarevTK.Sprint5.Task3.V18.Lib;
namespace Tyuiu.BondarevTK.Sprint5.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 2;
            string res = ds.SaveToFileTextData(x);
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
