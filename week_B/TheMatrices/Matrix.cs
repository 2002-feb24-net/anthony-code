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
        int[,] matrix_1;


        // allows user input to set the size of the matrix
        public int[,] SetMatrix()
        {
            System.Console.WriteLine("How big do you want the matrix, your choice will set the columns and rows | Provide number 2 thru 10");
            int number = Int32.Parse(Console.ReadLine());
            int[,] newMatrix = new int[number,number];
            System.Console.WriteLine($"Matirx dimension is {newMatrix.Length}");
            return newMatrix;
        }
        
        // gets users numbers data
        public int[] getUserData(int[,] userMatrix)
        {
            Console.Clear();
            int[] userProvidedArray = new int[userMatrix.Length];
            System.Console.WriteLine("Please input numbers between 0 and 9");
            for(int c = 0; c < userProvidedArray.Length; c++)
            {
                System.Console.WriteLine("Enter Number Here: ");
                int num1 = Int32.Parse(Console.ReadLine());
                userProvidedArray[c] = num1;
                
            }
            Console.Clear();
            return userProvidedArray;
        }

        // moves user data to matrix fields *** THIS NEEDS UPDATED FOR DIFFERENT SIZE MATRIX
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

        //prints matrix after conversion - *** THIS NEEDS UPDATED FOR DIFFERENT SIZE MATRIX
        public void printData(int[,] newMatrix)
        {
            int a = newMatrix[0,0];
            int b = newMatrix[0,1];
            int c = newMatrix[1,0];
            int d = newMatrix[1,1];

            System.Console.WriteLine($"|{a} {b}|");
            System.Console.WriteLine($"|{c} {d}|");
        }

        // Add matrix together
        public void Add(int[,] first, int[,] second)
        {
            System.Console.WriteLine("This currently does nothing");
        }

        // constructor to create matrix
        public Matrix()
        {
            int[,] userMatrix = SetMatrix();
            int[] userData = getUserData(userMatrix);
            int[,] newMatrix = moveDataToMatrix(userData);
            printData(newMatrix);
        }
    }
}