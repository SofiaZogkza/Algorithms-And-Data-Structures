using System;

namespace ArraysAndStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region IsUnique
            Console.WriteLine("Is the string unique? : " + IsUnique.IsUniqueString("sofia"));
            Console.WriteLine("Is the string unique? : " + IsUnique.IsUniqueString2("softsoftr"));
            #endregion

            #region Permutation
            CheckPermutation.IsPermutation("ssofia","fiasos");
            #endregion

            URLify.UrlifyTheString("Your  Name i   o");


            Console.ReadLine();
        }
    }
}
