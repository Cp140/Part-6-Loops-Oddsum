using System;

namespace Part_6_Loops__Oddsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddSum;
            int totalSum;
            oddSum = 0;

            Console.WriteLine("Please enter an integer:");
            while (!Int32.TryParse(Console.ReadLine(), out oddSum))
                Console.WriteLine("Please enter a valid number");

            for (oddSum <= 0; oddSum = oddSum - 2)
            {
                totalSum = (totalSum + (totalSum + 2));



                Console.WriteLine();
            }








            Console.WriteLine($"Thanks for {oddSum}!");
        }
    }
}
