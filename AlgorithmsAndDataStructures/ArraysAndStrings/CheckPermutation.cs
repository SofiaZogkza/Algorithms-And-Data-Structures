using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings
{
    public class CheckPermutation
    {
        public static bool IsPermutation(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;
            if (str1.Length == 0) return true;
            
            Dictionary<char,int> tb1 = new Dictionary<char, int>();

            foreach (var character in str1)
            {
                if (tb1.ContainsKey(character))
                {
                    tb1[character] = tb1[character] + 1;
                }
                else
                {
                    tb1[character] = 1;
                }                    
            }

            foreach (var character in str2)
            {
                if (tb1.ContainsKey(character))
                {
                    tb1[character]--;
                    if (tb1[character] < 0)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }                
            }

            return true;
        }

        
    }
}
