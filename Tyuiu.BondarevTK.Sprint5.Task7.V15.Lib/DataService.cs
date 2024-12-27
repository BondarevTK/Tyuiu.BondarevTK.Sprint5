using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BondarevTK.Sprint5.Task7.V15.Lib
{
    public class DataService : ISprint5Task7V15
    {
        public string LoadDataAndSave(string path)
        {
            string savepath = $@"{Path.GetTempPath()}/OutPutDataFileTask7V15.txt";
            string text = File.ReadAllText(path);
            string[] strings = text.Split(new char[] {' '});
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == 2)
                {
                    strings[i] = "";
                }
            }
            string res = string.Join(" ", strings);
            File.WriteAllText(savepath, res);
            return savepath;
        }
    }
}
