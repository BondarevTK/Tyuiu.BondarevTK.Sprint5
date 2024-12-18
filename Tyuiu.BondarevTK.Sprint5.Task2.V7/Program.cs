using Tyuiu.BondarevTK.Sprint5.Task2.V7.Lib;
namespace Tyuiu.BondarevTK.Sprint5.Task2.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] matrix = { { 9, 2, 8 }, { 7, 1, 2 }, { 5, 5, 1 } };
            string res = ds.SaveToFileTextData(matrix);
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
