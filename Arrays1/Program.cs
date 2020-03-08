using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 8;
            grades[1] = 9;
            grades[2] = 6;
            grades[3] = 5;
            grades[4] = 9;

            Console.WriteLine("Grades after first exam: ");
            Console.WriteLine($"Andrew = {grades[0]}");
            Console.WriteLine($"Julie = {grades[1]}");
            Console.WriteLine($"Mark = {grades[2]}");
            Console.WriteLine($"Oswald = {grades[3]}");
            Console.WriteLine($"Mary = {grades[4]}");
            Console.WriteLine();


            grades[0] = getValidInt("Andrew");
            grades[1] = getValidInt("Julie");
            grades[2] = getValidInt("Mark");
            grades[3] = getValidInt("Oswald");
            grades[4] = getValidInt("Mary");

            Console.WriteLine("\nGrades after finale exam: ");
            Console.WriteLine($"Andrew = {grades[0]}");
            Console.WriteLine($"Julie = {grades[1]}");
            Console.WriteLine($"Mark = {grades[2]}");
            Console.WriteLine($"Oswald = {grades[3]}");
            Console.WriteLine($"Mary = {grades[4]}");
            Console.WriteLine();

            Console.WriteLine($"There are currently {grades.Length} grades available..."); ;
        }

        static int getValidInt(string studentName)
        {
            int outputInt;
            while (true)
            {
                Console.Write($"Enter a new grade for {studentName}: ");
                string newGrade = Console.ReadLine();
                bool conversionSuccess = Int32.TryParse(newGrade, out outputInt);
                if (conversionSuccess && outputInt >= 0 && outputInt <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid integer. Try again...");
                }
            }
            return outputInt;
        }
    }
}
