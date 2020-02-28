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
        static string getAronym(string str)
        {
            string[] arr = str.Split(" ");
            
        }
        static void Main(string[] args)
        {
            string userPhrase = getPhrase();
        }
    }
}
