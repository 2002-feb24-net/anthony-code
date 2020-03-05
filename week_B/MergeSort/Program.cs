/* 
Author: Anthony Harrington
Date: 03/05/2020
Project: MergeSort Algorithm (8, 5, 7, 1, 6, 3, 4, 2)
*/

using System;
using System.Collections.Generic;

namespace MergeSort
{
    class Program
    {

        
        
        static void Main(string[] args)
        {
            int[] data = {8, 5, 7, 1, 6, 3, 4, 2};
            System.Console.WriteLine($"Before Sort : {data}");
            sortData(data);
            System.Console.WriteLine($"After Sort : {data}");


            //1. split array in half
            //2. keep splitting until you cannot cut in half anymore
            //3. combine two arrays, one by one through both of them
            //
        
            static void sortData(int[] array)
            {
                //base case
                if(array.Length < 2) return;
                if(array.Length == 1) return;
                // recursive case
                int middle = array.Length/2;

                int[] left = SubArray(array, 0, middle);
                int[] right = SubArray(array, middle, array.Length);

                sortData(left);
                sortData(right);

                int l = 0;
                int r = 0;
                int[] result = new int[array.Length];
                for(int i = 0; i < array.Length; i++)
                {
                    if(l >= left.Length)
                    {
                        result[i] = right[r];
                        r++;
                    }
                    else if(r >= right.Length)
                    {
                        result[i] = left[l];
                        l++;
                    }
                    if(left[l] <= right[r])
                    {
                        result[i] = left[l];
                        l++;
                    }
                    else
                    {
                        result[i] = right[r];
                        r++;
                    }
                }

            }

            static int[] SubArray(int[] array, int start, int end)
            {
                int length = end - start;
                int[] result = new int[length];
                for(int i = 0; i < length; i++)
                {
                    
                }
            }

            
        }
    }
}
