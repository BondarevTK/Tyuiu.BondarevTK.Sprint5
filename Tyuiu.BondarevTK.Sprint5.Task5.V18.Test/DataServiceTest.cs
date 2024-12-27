namespace Tyuiu.BondarevTK.Sprint5.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();
            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            Assert.IsTrue(fileExists);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string text = "13.93 7 -8 2 8 -6.61 19 11.88 -5 1 12.33 2.71 5 5.66 -7 14 -1.27 -2.49 7.23 3";
            string[] strings = text.Split(" ");
            double res = 1;
            foreach (string s in strings)
            {
                if (Double.TryParse(s, out double number) && Math.Abs(number) > 9 && Math.Abs(number) < 100)
                {
                    res = res * number;
                }
            }
            Assert.AreEqual(Math.Round(res,3), 542765.545);
        }
    }
}