using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MotorovaDD.Sprint5.Task5.V1.Lib
{
    public class DataService : ISprint5Task5V1
    {
        private double min;
        private object rd;

        public double LoadFromDataFile(string path)

        {
            using (StreamReader reader = new StreamReader(path))

            {
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) % 2 == 0 && Convert.ToDouble(line) < min)
                    {
                        min = Convert.ToDouble(line);
                    }

                }
                return Math.Round(min, 3);
            }
        }
    }
}
