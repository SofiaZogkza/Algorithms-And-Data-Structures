using System.Collections.Generic;

namespace ArraysAndStrings
{
    public class C1_04_PalindromePermutation
    {
        public static bool IsPalindrome(string str)
        {
            int strLength = str.Length - 1;

            for (int i = 0; i < strLength; i++)
            {
                if (str[i] != str[strLength - i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsPermutation(string str)
        {
            if (str == null) return false;
            Dictionary<char, int> strDict = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (strDict.ContainsKey(str[i]))
                {
                    strDict[str[i]] = strDict[str[i]] + 1;
                }
                else
                {
                    strDict[str[i]] = 1;
                }
            }
            var valueOccurs = 0;
            foreach (var i in strDict)
            {
                // EVEN NUMBERS
                if (strDict.Count % 2 == 0)
                {
                    if (strDict[i.Key] % 2 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                // ODD NUMBERS - One value must be unique, the rest must be 
                else
                {
                    if (strDict[i.Key] % 2 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        if (valueOccurs > 1) return false;
                        valueOccurs = valueOccurs + 1;
                    }
                }
            }
            return false;
        }
    }
}
