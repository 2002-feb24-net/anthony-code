using System;

namespace week1_AcronymFinder
{
    class Program
    {
        // requests phrase from user
        static string getPhrase()
        {
            System.Console.WriteLine("Please enter a phrase to get the Acronym");
            string a = Console.ReadLine();
            return a;
        }

        // gets acronym from phrase
        static string[] getAronym(string str)
        {
            string[] arr = str.Split(" ");
            string[] newArr = new string[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                string strA = arr[i];
                string strB = strA.Substring(0, 1);
                newArr[i] = strB;
            }
            return newArr;
        }

        // prints new Acronym to console
        static void printStuff(string[] str)
        {
            System.Console.WriteLine("Your Acronym to your Phrase is : ");
            for(int x = 0; x < str.Length; x++)
            {
                System.Console.Write(str[x]);
            }
        }

        // Main Program Class Method
        static void Main(string[] args)
        {
            string userPhrase = getPhrase();
            string[] acc = getAronym(userPhrase);
            printStuff(acc);
        }
    }
}
