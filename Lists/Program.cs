using System;
using System.Collections;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            // Simple int array:
            int[] myIntArray = { 1, 3, 5, 7, 9 };

            // Simple ArrayList:
            ArrayList myArrayList = new ArrayList() { 1, 3, 5, 7, 9 };

            // Simple List:
            List<int> myList = new List<int> {1, 23, 95, 71, 19};
            myList.Add(0);
            myList.Add(32);

            Console.WriteLine("Original List: ");
            ListPrinter(myList);

            myList.Sort();
            Console.WriteLine("List after sorting: ");
            ListPrinter(myList);

            myList.Reverse();
            Console.WriteLine("List after reversing: ");
            ListPrinter(myList);

            myList.RemoveRange(2, 2);
            Console.WriteLine("List after 2 items from index 2 were removed: ");
            ListPrinter(myList);

            Console.WriteLine($"Is the value '5' in myList? {myList.Contains(5)}");
            Console.WriteLine($"Is the value '1' in myList? {myList.Contains(1)}");
            Console.WriteLine();

            Console.WriteLine($"myList.FindIndexOf(myList.FindIndex(number => number == 1000)) = {myList.FindIndex(number => number == 1000)}");
            Console.WriteLine($"myList.FindIndexOf(myList.FindIndex(number => number == 1)) = {myList.FindIndex(number => number == 1)}");
            Console.WriteLine($"myList.FindIndexOf(myList.FindIndex(number => number == 95)) = {myList.FindIndex(number => number == 95)}");

        }

        static void ListPrinter(List<int> aList)
        {
            int index = 0;
            foreach (int item in aList)
            {
                Console.WriteLine($"aList[{index}] = {item}");
                index++;
            }
            Console.WriteLine();
        }

        static bool isEqual(int x)
        {
            return x == 1000;
        }
    }
}
