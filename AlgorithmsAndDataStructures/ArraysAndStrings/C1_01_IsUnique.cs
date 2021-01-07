using System.Collections.Generic;

namespace ArraysAndStrings
{
    public class C1_01_IsUnique
    {
        public static bool IsUniqueString(string str)
        {
            var checker = 0;
            for (var i = 0; i < str.Length; i++)
            {
                var val = str[i];

                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);
            }

            return true;
        }

        public static bool IsUniqueString2(string str)
        {
            var hashset = new HashSet<char>();
            foreach (var c in str)
            {
                if (hashset.Contains(c)) return false;
                hashset.Add(c);
            }

            return true;
        }
    }
}
