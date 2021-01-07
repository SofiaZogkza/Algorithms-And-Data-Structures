using System;
using System.Text;

namespace ArraysAndStrings
{
    public class C1_06_StringCompression
    {
        // aabcccccaaa - > a2b1c5a3.
        public static string CompressString(string str)
        {
            int count = 1;
            int finalLength = CountCompression(str);
            if (finalLength >= str.Length)
            {
                return str;
            }

            StringBuilder compressedStr = new StringBuilder();
           
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    count++;
                    if((i+1) == str.Length - 1)
                    {
                        compressedStr.Append(str[i]).Append(count);
                    }
                }
                else
                {
                    compressedStr.Append(str[i]).Append(count);
                    count = 1;
                }                
            }
            Console.WriteLine("str: " + str);
            Console.WriteLine("Compressed String: " + compressedStr);

            if (compressedStr.Length> str.Length)
            {
                return str;
            }

            return compressedStr.ToString();
        }

        private static int CountCompression(String str)
        {
            int compressedLength = 0;
            int countConsecutive = 0;
            for (int i = 0; i < str.Length; i++)
            {
                countConsecutive++;
                
                /* If next character is different than current, increase the length. */
                if (i + 1 >= str.Length || 
                    str[i] != str[i + 1])
                {
                    compressedLength += 1 + (countConsecutive).ToString().Length;
                    countConsecutive = 0;
                }
            }
            return compressedLength;
        }
    }
}
