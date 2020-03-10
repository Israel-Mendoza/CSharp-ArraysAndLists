using System;

namespace ArraysAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] happiness = { 6, 7, 8, 8, 9, 5, 5 };
            SunIsShining(happiness);
            foreach (int number in happiness)
            {
                Console.Write($"{number}  ");
            }

        }

        static void SunIsShining(int[] anArray)
        {
            for (int i=0; i<anArray.Length; i++)
            {
                anArray[i] += 2;
            }
        }
    }
}