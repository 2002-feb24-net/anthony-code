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
        //fields = how will we store the data of this matrix
        //int number;
        int[,] matrix = new int[2, 2];
        //int[] userProvidedArray = new int[4];


        /* Methods
        1. some way to fill the data
        2. some common matrix operations (matrix addition, matrix negation, multiplication, transpose)
        */

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
            System.Console.WriteLine("GetUserData completed");
            return userProvidedArray;
        }

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

        public void printData(int[,] newMatrix)
        {
            foreach(int num in newMatrix)
            {
                System.Console.WriteLine(num);
            }
            //System.Console.WriteLine($"");
        }

        public void createMatrix()
        {
            int[] userData = getUserData();
            System.Console.WriteLine("NEXT METHOD");
            int[,] newMatrix = moveDataToMatrix(userData);
            printData(newMatrix);
        }
    }
}