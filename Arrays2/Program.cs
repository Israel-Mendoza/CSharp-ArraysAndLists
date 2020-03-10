using System;
using System.Linq;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFriends = { "Victor", "Fernando", "Miguel", "Sergio", "Claudio" };
            string[] myFriends2 = { "Victor", "Fernando", "Miguel", "Sergio", "Claudio" };
            int[] myGrades = { 1, 5, 95, 2, 125 };

            Console.WriteLine("These are the contents of the \"myFriends\" array: ");
            ArrayPrinter(myFriends);

            Console.WriteLine("These are the contents of the \"myGrades\" array: ");
            ArrayPrinter(myGrades);


            Array.Sort(myFriends);

            Array.Sort(myGrades);

            Console.WriteLine("These are the contents of the \"myFriends\" array after sorting: ");
            ArrayPrinter(myFriends);

            Console.WriteLine("These are the contents of the \"myGrades\" array after sorting: ");
            ArrayPrinter(myGrades);

            Array.Reverse(myFriends);

            Array.Reverse(myGrades);

            Console.WriteLine("These are the contents of the \"myFriends\" array after reversing: ");
            ArrayPrinter(myFriends);

            Console.WriteLine("These are the contents of the \"myGrades\" array after reversing: ");
            ArrayPrinter(myGrades);

            Console.WriteLine($"Where is Sergio located in myFriends array? {Array.IndexOf(myFriends, "Sergio")}");
            Console.WriteLine($"Is Omar in myFriends array? {(Array.IndexOf(myFriends, "Omar") != -1 ? "Yes!" : "Nope!")}");
            Console.WriteLine($"Is Sergio in myFriends array? {(Array.IndexOf(myFriends, "Sergio") != -1 ? "Yes!" : "Nope!")}\n");


            Console.WriteLine($"Is myFriends1 equal to myFriends2? {Enumerable.SequenceEqual(myFriends, myFriends2)}");
            Array.Sort(myFriends2);
            Array.Reverse(myFriends2);
            Console.WriteLine($"Is myFriends1 equal to myFriends2? {Enumerable.SequenceEqual(myFriends, myFriends2)}");

        }

        static void ArrayPrinter(string[] anArray)
        {
            foreach (string item in anArray)
            {
                Console.WriteLine($"\t{item}");
            }
            Console.WriteLine();
        }

        static void ArrayPrinter(int[] anArray)
        {
            foreach (int number in anArray)
            {
                Console.WriteLine($"\t{number}");
            }
            Console.WriteLine();
        }
    }
}
