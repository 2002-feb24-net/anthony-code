using System;
using Palindrome.Library;
using XUnitTest;

namespace Palindrome
{
    class Program : UnitTest1, IInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase with no spaces");
            string userInput = Console.ReadLine();

            Console.WriteLine(ReverseString.RString(userInput));
            string changedString = ReverseString.RString(userInput);
            string answer = StringHelper.StringTester(userInput, changedString);
            Console.WriteLine(answer);

        }

        

        public string UserInput()
        {
            throw new NotImplementedException();
        }
    }
}
