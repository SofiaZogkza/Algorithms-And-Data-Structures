using System;
using System.Collections.Generic;

namespace IsUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            string isUnique = "sofiatyr";
            string test = "ff";
            Console.WriteLine("Test " + test);
            Console.WriteLine("Is the string unique? : " + IsUniqueString2(isUnique));

            Console.ReadLine();
        }

        private static bool IsUniqueString(string str)
        {
            var checker = 0;
            for (var i = 0; i < str.Length; i++)
            {
                var val = str[i] ;

                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);
            }

            return true;
        }

        private static bool IsUniqueString2(string str)
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
