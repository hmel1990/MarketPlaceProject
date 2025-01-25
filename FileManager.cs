using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace FormMarket
{
    internal class FileManager
    {

        public List<Product> deserializationFromJson(string pathToJsonWithProducts)
        {
            try
            {
                // изначально было несколько строк, создаем List, создаем строку с содержимым, десериализуем, записываем в List, возвращаем List,
                // решил все одной строкой записать.

                return JsonSerializer.Deserialize<List<Product>>(File.ReadAllText(pathToJsonWithProducts));

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при десериализации файла: {ex.Message}");
                return new List<Product>();
            }

        }


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

        public void addStringToFile(string path, string newLine)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(newLine);
            }
        }


        public void writeUsersGridViewToFile(DataTable tableUsers, string pathToProducts)
        {
            using (var writer = new StreamWriter(pathToProducts))
            {
                // Запись заголовков
                var headers = string.Join("\t", tableUsers.Columns.Cast<DataColumn>().Select(column => column.ColumnName));
                writer.WriteLine(headers);

                // Запись данных строк
                foreach (DataRow row in tableUsers.Rows)
                {
                    var values = string.Join("\t", row.ItemArray);
                    writer.WriteLine(values);
                }
            }
        }
    }

}
