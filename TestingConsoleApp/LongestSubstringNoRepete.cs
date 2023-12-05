using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApp
{
    public class LongestSubstringNoRepete
    {
        public static int LongestSubstring(string str)
        {
            IDictionary<char, char> map = new Dictionary<char, char>();
            List<IDictionary<char, char>> mapList = new List<IDictionary<char, char>>();
            //pwwkeawertgkeh

            foreach (var item in str)
            {
                try
                {
                    map.Add(item, item);
                }
                catch (Exception)
                {
                    mapList.Add(map);
                    map = new Dictionary<char, char>();
                    map.Add(item, item);
                }
            }
            mapList.Add(map);

            var maxCount = mapList.OrderByDescending(x => x.Count).First();
            return maxCount.Count();
        }
    }
}
