using System;

namespace LoopingThroughArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = new int[10];

            for (int i=0; i< myNumbers.Length; i++)
            {
                myNumbers[i] = i * 10;
            }

            for (int j=0; j<myNumbers.Length; j++)
            {
                Console.WriteLine($"Element at position {j}: {myNumbers[j]}");
            }
            Console.WriteLine();

            int counter = 0;
            foreach (int num in myNumbers)
            {
                Console.WriteLine($"Element at position {counter}: {num}");
                counter++;
            }
            Console.WriteLine();

            string[] myFriends = { "Victor", "Fernando", "Sergio", "Claudio", "Carlos" };
            foreach (string friend in myFriends)
            {
                Console.WriteLine($"Hello, {friend}, my friend... How are you today?");
            }
        }
    }
}
