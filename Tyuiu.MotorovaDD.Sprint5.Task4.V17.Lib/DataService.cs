﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MotorovaDD.Sprint5.Task4.V17.Lib
{
    public class DataService : ISprint5Task4V17
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Round((Math.Sin(2 / (3 * Convert.ToDouble(strX))) + (Math.Pow(Convert.ToDouble(strX), 2))), 3);
            return res;
        }
    }
}


