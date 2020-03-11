using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an ArrayList with undefined amount of objects
            ArrayList myArrayList = new ArrayList();

            // Declare an ArrayList with a defined amount of objects
            ArrayList myArrayList2 = new ArrayList(20);

            myArrayList.Add(25);
            myArrayList.Add(25.25);
            myArrayList.Add(25);
            myArrayList.Add(2);
            myArrayList.Add("Hello");
            myArrayList.Add(true);
            myArrayList.Add(2.1255f);


            int index = 0;
            foreach (object item in myArrayList)
            {
                Console.WriteLine($"myArrayList[{index}] = {item}");
                index++;
            }

            myArrayList.Remove(15);
        }
    }
}