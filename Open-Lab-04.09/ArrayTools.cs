using System;
using System.Collections.Generic;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            HashSet<string> set = new HashSet<string>(strings);
            string[] result = new string[set.Count];
            set.CopyTo(result);
            return result;
        }
    }
}
