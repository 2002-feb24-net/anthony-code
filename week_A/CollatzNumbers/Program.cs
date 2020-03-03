using System;

// Author: Anthony Harrington
// Feb 28 2020
// make a program that prints the Collatz sequence (up until 1) for a given number,
// taking the number from Console.ReadLine.
// for any number n, the next number in its Collatz sequence is:
//     - if n is even, it is n divided by two.
//     - if n is odd, it is n times three, plus one.

namespace CollatzNumbers
{
    class Program
    {

        //get number from user input
        static int getUserNumber()
        {
            Console.WriteLine("Enter a Number");
            string num = Console.ReadLine();
            int number = int.Parse(num);
            return number;
        }

        // factor number down to 1
        static void factorNumber(int n)
        { 
            while (n != 1)
            {
                int r = n%2;
                if (r == 0)
                {
                    n = n/2;
                    System.Console.WriteLine(n);
                }
                else
                {
                    n = n*3+1;
                   System.Console.WriteLine(n);
                }
            }
        }

        static void Main(string[] args)
        {
            int usersNumber = getUserNumber();
            factorNumber(usersNumber);
            
        }
    }
}
