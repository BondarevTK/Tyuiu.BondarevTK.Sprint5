using System.Text;
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
            StreamReader br = new StreamReader(res);
            string line = br.ReadLine();
            while (line != null)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(line);
                line = Convert.ToBase64String(bytes);
                Console.WriteLine(line);
                line = br.ReadLine();
            }
        }
    }
}
