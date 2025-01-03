﻿using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BondarevTK.Sprint5.Task4.V16.Lib
{
    public class DataService : ISprint5Task4V16
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            var fmt = new NumberFormatInfo();
            fmt.NegativeSign = "−";
            var x = double.Parse(strx, fmt);
            double res = Math.Cos(x) + Math.Pow(x, 2) - 2 * (x / 1.2);
            res = Math.Round(res, 3);
            return res;
        }
    }
}
