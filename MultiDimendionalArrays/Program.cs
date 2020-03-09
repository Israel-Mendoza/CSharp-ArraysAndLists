using System;

namespace MultiDimendionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2D array declaration
            string[,] twoDimArray;

            // 3D array declaration
            int[,,] threeDimArray;

            // Initializing the multidimentional arrays
            int[,] myArray = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine($"First value in first inner array: {myArray[0,0]}");
            Console.WriteLine($"First value in second inner array: {myArray[1, 0]}");
            Console.WriteLine($"First value in third inner array: {myArray[2, 0]}");
            Console.WriteLine();
            Console.WriteLine($"Second value in first inner array: {myArray[0, 1]}");
            Console.WriteLine($"Second value in second inner array: {myArray[1, 1]}");
            Console.WriteLine($"Second value in third inner array: {myArray[2, 1]}");
            Console.WriteLine();
            Console.WriteLine($"Third value in first inner array: {myArray[0, 2]}");
            Console.WriteLine($"Third value in second inner array: {myArray[1, 2]}");
            Console.WriteLine($"Third value in third inner array: {myArray[2, 2]}");

            string[,,] myStringArray = new string[,,]
            {
                {
                    {"Israel", "Margarita"},
                    {"Arturo", "Antonia"}
                },
                {
                    {"Carlos", "Connie"},
                    {"Miguel", "Judith"}
                }
            };

            Console.WriteLine($"First name in first array in first array: {myStringArray[0, 0, 0]}");
            Console.WriteLine($"Second name in first array in first array: {myStringArray[0, 0, 1]}");
            Console.WriteLine($"First name in second array in first array: {myStringArray[0, 1, 0]}");
            Console.WriteLine($"Second name in second array in first array: {myStringArray[0, 1, 1]}");
            Console.WriteLine($"First name in first array in second array: {myStringArray[1, 0, 0]}");
            Console.WriteLine($"Second name in first array in second array: {myStringArray[1, 0, 1]}");
            Console.WriteLine($"First name in second array in second array: {myStringArray[1, 1, 0]}");
            Console.WriteLine($"Second name in second array in second array: {myStringArray[1, 1, 1]}");
            Console.WriteLine();


            int[,] new2DArray = new int[5, 5];

            int counter = 0;

            for (int firstDimention=0; firstDimention<new2DArray.GetLength(0); firstDimention++)
            {
                for (int secondDimention=0; secondDimention < new2DArray.GetLength(1); secondDimention++)
                {
                    new2DArray[firstDimention, secondDimention] = counter;
                    counter++;
                }
            }

            Console.WriteLine(new2DArray[0, 0]);
            Console.WriteLine(new2DArray[0, 1]);
            Console.WriteLine(new2DArray[0, 2]);
            Console.WriteLine(new2DArray[0, 3]);
            Console.WriteLine(new2DArray[0, 4]);
            Console.WriteLine(new2DArray[1, 0]);
            Console.WriteLine(new2DArray[1, 1]);
            Console.WriteLine(new2DArray[1, 2]);
            Console.WriteLine(new2DArray[1, 3]);
            Console.WriteLine(new2DArray[1, 4]);

        }
    }
}
