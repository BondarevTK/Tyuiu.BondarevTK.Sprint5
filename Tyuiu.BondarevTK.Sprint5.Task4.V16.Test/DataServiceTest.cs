namespace Tyuiu.BondarevTK.Sprint5.Task4.V16.Test
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
    }
    }
}