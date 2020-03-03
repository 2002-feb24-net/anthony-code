/* 
Author: Anthony Harrington
Date: 03/02/2020
Assignment: Week B Fizz Buzz

For each number from 1 to 1000 in order,
* print "Fizz" for the ones divisible by 3 (& not 5)
* print "Buzz" for the ones divisible by 5 (& not 3)
* print "Fizzbuzz" for the ones divisible by both 3 and 5
* print the number itself, for all the rest of the numbers
Also, I want to know, at the end, how many Fizz, how many Buzz, how many Fizzbuzz.
Your code should calculate that, and, put the numbers you get in a comment, so I
can see them without running the code.

*/


using System;

namespace WeekB_FizzBuzz
{
    class Program
    {

        // Loop of Numbers
        static void LoopThruNumbers()
        {
            int byFive = 0;
            int byThree = 0;
            int byFiveAndThree = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i%3 == 0 && i%5 != 0)
                {
                    System.Console.WriteLine(i + "  Fizz");
                    byThree++;
                }
                if (i%5 == 0 && i%3 != 0)
                {
                    System.Console.WriteLine(i + "  Buzz");
                    byFive++;
                }
                if (i%3 == 0 && i%5 == 0)
                {
                    System.Console.WriteLine(i + "  Fizzbuzz");
                    byFiveAndThree++;
                }
                else
                {
                    System.Console.WriteLine(i + "  NULL");
                }
            }

            System.Console.WriteLine("Numbers devided by 3 but not 5 =  " + byThree);
            System.Console.WriteLine("NUmbers devided by 5 but not 3 =  " + byFive);
            System.Console.WriteLine("Numbers devided by 3 and 5 =  " + byFiveAndThree);
        }
        static void Main(string[] args)
        {
            LoopThruNumbers();

            /* TOTALS
            Numbers devided by 3 but not 5 =  267
            NUmbers devided by 5 but not 3 =  134
            Numbers devided by 3 and 5 =  66
            */
        }
    }
}
