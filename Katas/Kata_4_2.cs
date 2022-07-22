using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Katas
{
    public class Kata_4_2
    {
        public List<string> Top3(string s)
        {
            s = s.ToLower();
            List<string> list = new List<string>();
            char[] separators = new char[] { ' ', '.', '#', '\\', '/', ',' };
            string[] arr = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(string.Join("\n", arr));
            list = arr.GroupBy(x => x)
               .ToDictionary(x => x.Key, y => y.Count())
               .OrderByDescending(x => x.Value)
               .ThenBy(x => x.Key)
               .Take(3)
               .Select(x => x.Key)
               .ToList();

            char c = '\'';

            if (list.All(s => s == "'"))
                list = new List<string>();

            return list;
        }
    }
}
