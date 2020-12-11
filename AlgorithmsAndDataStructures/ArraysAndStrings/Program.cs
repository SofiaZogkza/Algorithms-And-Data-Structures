using System;

namespace ArraysAndStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region IsUnique
            //Console.WriteLine("Is the string unique? : " + IsUnique.IsUniqueString("sofia"));
            //Console.WriteLine("Is the string unique? : " + IsUnique.IsUniqueString2("softsoftr"));
            #endregion

            #region Permutation
            //CheckPermutation.IsPermutation("ssofia","fiasos");
            #endregion

            #region URLify
            //URLify.UrlifyTheString("Your  Name i   o");
            #endregion

            #region Palindrome Permutation
            Console.WriteLine("abcba is Palindrome: " + PalindromePermutation.IsPalindrome("abcba"));
            Console.WriteLine("abcbba is Palindrome: " + PalindromePermutation.IsPalindrome("abcbba"));
            Console.WriteLine("abba is Palindrome: " + PalindromePermutation.IsPalindrome("abba") + "\n");

            Console.WriteLine("abba is Palindrome Permutation: " + PalindromePermutation.IsPermutation("abba"));
            Console.WriteLine("abcccba is Palindrome Permutation: " + PalindromePermutation.IsPermutation("abba"));
            Console.WriteLine("abbacc is Palindrome Permutation: " + PalindromePermutation.IsPermutation("abba"));
            Console.WriteLine("abcbba is Palindrome Permutation: " + PalindromePermutation.IsPalindrome("abcbba") + "\n");
            #endregion

            Console.ReadLine();
        }
    }
}
