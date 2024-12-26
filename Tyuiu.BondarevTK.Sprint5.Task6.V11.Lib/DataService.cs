using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BondarevTK.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string text = File.ReadAllText(path);
            string[] strings = text.Split(new char[] { ' ', ',', '?' });
            for (int i = 0; i < strings.Length; i++)
            {
                if ( strings[i].Length == 6)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
