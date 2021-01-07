using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndStrings
{
    public static class C1_05_OneWay
    {
        public static bool CheckIfOneEdit(string str1, string str2)
        {
            Console.WriteLine("String 1 : " + str1 + "\nString 2 : " + str2);

            var dict1 = new Dictionary<char, int>();
            var dict2 = new Dictionary<char, int>();

            foreach (var s in str1)
            {
                if(dict1.ContainsKey(s))
                {
                    dict1[s]++;
                }
                dict1[s] = 1;
            }


            var loopCount = 0;
            var replaceCount = 0;
            if(dict1.Count == str2.Length)
            {
                foreach (var item in dict1.Keys.ToList())
                {                    
                    if(item == str2[loopCount])
                    {
                        dict1[item]--;
                    }
                    else
                    {
                        replaceCount++;
                    }
                    loopCount++;
                }

                if (replaceCount >= 2)
                {
                    Console.WriteLine("There are " + replaceCount+ " edits!");
                    Console.WriteLine("Returns false!");
                    return false;
                }
                Console.WriteLine("There are " + replaceCount + " edits!");
                Console.WriteLine("Returns true!");
                return true;
            }


            foreach (var item in str2)
            {
                if (dict1.ContainsKey(item))
                {
                    dict1[item]--;
                }
                else
                {
                    dict1[item] = 1;
                }                
            }

            var count = 0;
            foreach(var item in dict1.Values)
            {
                if(item != 0)
                {
                    count++;
                }
            }

            Console.WriteLine("There are " + count + " edits!");

            if (count >= 2)
            {
                Console.WriteLine("Returns false!");
                return false;
            }
            Console.WriteLine("Returns true!");
            return true;
        }

    }
}
