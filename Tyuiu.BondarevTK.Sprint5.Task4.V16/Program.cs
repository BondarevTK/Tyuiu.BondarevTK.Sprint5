using Tyuiu.BondarevTK.Sprint5.Task4.V16.Lib;
namespace Tyuiu.BondarevTK.Sprint5.Task4.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetTempFileName();
            string y = "4";
            File.AppendAllText(path, y);
            DataService ds = new DataService();
            Console.WriteLine(ds.LoadFromDataFile(path));


        }
    }
}
