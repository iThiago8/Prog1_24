using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace _240401_01.Utils
{
    public class ExportToFile
    {
        private const string dir = @"C:\Users\411730\Documents\Prog1_24\Arquivos";
        public static void SaveToDelimitedTxt(string fileName, string fileContent)
        {
            string filePath = $@"{dir}\{fileName}";

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            using(StreamWriter sw = File.CreateText(filePath))
            {
                sw.Write(fileContent);
            }
        }
    }
}