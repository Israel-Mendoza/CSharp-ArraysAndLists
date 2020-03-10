using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring a jagged array
            int[][] jaggedArray = new int[3][];

            // Declaring each array within the jagged array
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            // Declaring and initializing each array within the jagged array
            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5, 6 };
            jaggedArray[1] = new int[] { 1, 2, 3, 4, 5, 6, 7, };
            jaggedArray[2] = new int[] { 1, 2, 3 };

            // Declaring and initializing a jagged array

            int[][] jaggedArray2 = new int[][]
            {
                new int[]{1, 3, 5},
                new int[]{2, 4, 6},
                new int[]{1, 5, 9},
            };

            foreach (int[] intArray in jaggedArray)
            {
                foreach (int num in intArray)
                {
                    Console.WriteLine($"Current value in jagged array 1: {num}");
                }
            }
            Console.WriteLine();

            foreach (int[] intArray in jaggedArray2)
            {
                foreach (int num in intArray)
                {
                    Console.WriteLine($"Current value in jagged array 2: {num}");
                }
            }
        }
    }
}
