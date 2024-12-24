using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMarket
{
    internal class FileManager
    {
        public string[] readStringsFromFile(string path)
        {
            // Проверяем, существует ли файл
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден.", path);
            }
            string[] lines;
            try
            {
                // Считываем все строки из файла
                lines = File.ReadAllLines(path);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            // Проверяем, есть ли строки в файле
            if (lines.Length == 0)
            {
                throw new InvalidOperationException("Файл пуст.");
            }

            return lines;
        }
    }
}
