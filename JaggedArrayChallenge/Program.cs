using System;

namespace JaggedArrayChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFamily = { "Margarita", "Antonia" };

            string[][] myFriends =
            {
                new string[]{"Victor", "Fernando", "Jessica"},
                new string[]{"Lalo", "Sonia", "Alejandro"},
                new string[]{"Miriam", "Carlos", "Daniela"}
            };

            for (int i=0; i<myFamily.Length; i++)
            {
                for (int j=0; j< myFriends.Length; j++)
                {
                    for (int k=0; k< myFriends[j].Length; k++)
                    {
                        Console.WriteLine($"{myFriends[j][k]}. Let me introduce you to {myFamily[i]}. {myFamily[i]}, this is {myFriends[j][k]}.");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
