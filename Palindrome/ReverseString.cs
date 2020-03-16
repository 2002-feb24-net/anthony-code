using System;

namespace Palindrome
{
    public class ReverseString
    {
        public static string RString(string str)
        {
            char[] myCharArr = str.ToCharArray();
            Array.Reverse(myCharArr);
            return new string(myCharArr);
        }
    }
}