using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SSHTunnelManager.Util
{
    public class Helper
    {
        public static string JoinExceptionMessages(string sentence1, string sentence2)
        {
            var ret = string.Concat(Regex.Replace(sentence1, @"\.\s*$", ""), ". ", sentence2);
            return ret;
        }
    }
}
