using CsvHelper;
using System.Globalization;

namespace Mobiles.Core.Utils
{
    public static class CsvUtils
    {
        public static IEnumerable<T> ParseCsv<T>(string path)
        {
            using StreamReader reader = new(path);
            using CsvReader csv = new(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<T>().ToList();
        }
    }
}
