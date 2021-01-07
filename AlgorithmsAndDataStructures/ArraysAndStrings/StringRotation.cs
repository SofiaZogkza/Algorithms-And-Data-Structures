using System;

namespace ArraysAndStrings
{
    public class StringRotation
    {
        public static bool IsRotation(string str1, string str2)
        {
            if (str1.Length != str2.Length 
                || string.IsNullOrEmpty(str1) 
                || string.IsNullOrEmpty(str2))
            {
                Console.WriteLine("\"" + str1 + "\"" + " and " + "\"" + str2 + "\" cannot considered as Rotation of each other. They have differend length!");
                return false;
            }

            //s1s1 will contain every posible shift waterbottlewaterbottle
            var s1s1 = str1 + str1;

            if (s1s1.Contains(str2))
            {
                Console.WriteLine("\"" + str1 + "\"" + " is Rotation of " + "\"" + str2 + "\"");
                return true;
            }

            Console.WriteLine("\"" + str1 + "\"" + " is NOT Rotation of " + "\"" + str2 + "\"");
            return false;
        }
    }
}
