using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace HRSA
{
    public class CSV
    {
        public static IEnumerable<T> Read<T>(string path)
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<T>().ToArray(); // we need to perform some type of operation on it to prevent it
                return records;                              // from being a stream of IEnumerable, so we don't get random nullrefs
            }
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
