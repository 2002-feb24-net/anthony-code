using System;

namespace BubbleSort
{
    class Program
    {

        static bool BubbleSortPass(int[] arr)
        {
            bool moved = false;
            for(int i = 0; i<arr.Length-1; i++)
            {
                moved = true;
                int a = arr[i];
                int b = arr[i+1];
                if(a > b)
                {
                    arr[i] = b;
                    arr[i+1] = a;
                    printArray(arr);
                }  
            }
            return moved;
        }


        static void printArray(int[] myArray)
        {
            for(int i = 0; i < myArray.Length; i++)
            {
                System.Console.Write(myArray[i]);
            }
            System.Console.WriteLine("\n");
        }


        static void Main(string[] args)
        {
            int[] myArray = {6, 3, 2, 9, 1, 5};
            bool moved = BubbleSortPass(myArray);
            while(moved)
            {
                moved = BubbleSortPass(myArray);
            }
            
        }
    }
}
