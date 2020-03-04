/* 
Author Anthony Harrington
Date: 03/04/2020
Program: Matrix / Create Matrices using Array/Lists/Sets
*/

using System;

namespace TheMatrices
{
    class Matrix
    {
        //fields
        int[,] matrix = new int[2, 2];

        // gets users numbers data
        public int[] getUserData()
        {
            int[] userProvidedArray = new int[4];
            System.Console.WriteLine("Please input 4 different numbers between 0 and 9");
            for(int c = 0; c < userProvidedArray.Length; c++)
            {
                System.Console.WriteLine("Enter Number Here: ");
                string num1 = Console.ReadLine();
                int num = int.Parse(num1);
                userProvidedArray[c] = num;
                Console.Clear();
            }
            return userProvidedArray;
        }

        // moves user data to matrix fields
        public int[,] moveDataToMatrix(int[] userData)
        {
            int[,] matrix = new int[2, 2]
            {
                {userData[0], userData[1]},
                {userData[2], userData[3]},
            };
            System.Console.WriteLine("moveDataToMatrix completed");
            return matrix;
        }

        //prints matrix after conversion
        public void printData(int[,] newMatrix)
        {
            int a = newMatrix[0,0];
            int b = newMatrix[0,1];
            int c = newMatrix[1,0];
            int d = newMatrix[1,1];

            System.Console.WriteLine($"|{a} {b}|");
            System.Console.WriteLine($"|{c} {d}|");
        }

        public void Add(int[,] first, int[,] second)
        {
            
        }

        // creates matrix
        public void createMatrix()
        {
            int[] userData = getUserData();
            int[,] newMatrix = moveDataToMatrix(userData);
            printData(newMatrix);
        }
    }
}