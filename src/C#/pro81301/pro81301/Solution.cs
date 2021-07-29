using System;
using System.Collections.Generic;
using System.Text;

namespace pro81301
{
    class Solution
    {
        public static int soultion(string s)
        {
            Dictionary<string, string> numsAndWords = new Dictionary<string, string>
        { {"zero", "0"},
          {"one", "1"},
          {"two", "2"},
          {"three", "3"},
          {"four", "4"},
          {"five", "5"},
          {"six", "6"},
          {"seven", "7"},
          {"eight", "8"},
          {"nine", "9"}
        };

            foreach (var keyValue in numsAndWords)
            {
                s = s.Replace(keyValue.Key, keyValue.Value);
            }

            int answer = int.Parse(s);
            return answer;
        }
    }
}
