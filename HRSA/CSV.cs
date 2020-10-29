using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace HRSA
{
    public class CSV
    {
        public static IEnumerable<T> Read<T>(string path)
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                return csv.GetRecords<T>();
        }

        public static void Write(string path, System.Collections.IEnumerable records)
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
        }
    }
}
