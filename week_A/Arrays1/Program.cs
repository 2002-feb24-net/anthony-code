/* 
Author: Anthony Harrington
Date: 02/28/2020
Purpose: User inputs 3 numbers and program requests operational use of numbers provided and provides data of returned information
*/

using System;
using System.Linq;

namespace Arrays1
{
    class Program
    {
        // function to get user input
        static string[] GetInput()
        {
            
            string[] input = new string[3];
            for(int x = 0; x < input.Length; x++)
            {
                Console.WriteLine("Please enter a random number 1 thru 100: ");
                input[x] = Console.ReadLine();
            }
            return input;        
        }

        // function to print data
        static void printArray(int[] a)
        {
            Console.Write("Array =  ");
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "|");
            }
        }

        // function to convert the array from string characters to intigers
        static int[] ConvertToArray(string[] str)
        {
            int al = str.Length;
            int[] numbArray = new int[al];
            for(int i = 0; i < str.Length; i++)
            {
                numbArray[i] = int.Parse(str[i]);
            }
            return numbArray;
        }

        // funtion to convert array by users choice
        static void updateArray(int[] b)
        {
            System.Console.WriteLine("\n");
            System.Console.WriteLine("\nPlease enter a number for what type of process to complete with your numbers");
            System.Console.WriteLine("1: Add\n2: Subtract\n3: Multiply\n4: Devide\n5: Reverse Numbers\n6: Add 5 to each numbeer");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                int x = b.Sum();
                System.Console.WriteLine("The Sum in all of your numbers entered = " + x);
            }
            if(userInput == "2")
            {
                int y = b[0]- b[1] - b[2];
                System.Console.WriteLine("The difference of all of your numbers entered = " + y);
            }
            if(userInput == "3")
            {
                int y = b[0] * b[1] * b[2];
                System.Console.WriteLine("The product of all of your numbers entered = " + y);
            }
            if(userInput == "4")
            {
                int y = b[0] / b[1] / b[2];
                System.Console.WriteLine("The quotient of all of your numbers entered = " + y);
            }
            if(userInput == "5")
            {
                Array.Reverse(b);
                printArray(b);
            }
            if(userInput == "6")
            {
                for(int i = 0; i < b.Length; i++)
                {
                    b[i] = b[i] + 5;
                }
                printArray(b);
            }
        }

        // Main Program Class function
        static void Main(string[] args)
        {
            string[] input = GetInput();
            int[] numArray = ConvertToArray(input);
            Console.WriteLine("Your numbers listed in an Array : ");
            printArray(numArray);
            updateArray(numArray);            
        }
    }
}
