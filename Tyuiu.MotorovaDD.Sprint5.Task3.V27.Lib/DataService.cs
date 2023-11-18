using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MotorovaDD.Sprint5.Task3.V27.Lib
{
    public class DataService : ISprint5Task3V27
    {
        public string SaveToFileTextData(int x)
        {
         

            String path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            double res = Math.Pow(x, 1) + 1;

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(x));
            }

            return path;
        }
    }
}
