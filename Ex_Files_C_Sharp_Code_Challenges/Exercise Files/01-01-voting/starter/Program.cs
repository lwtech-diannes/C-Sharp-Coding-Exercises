using System;

namespace voting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("How old are you?");
            int input = int.Parse(Console.ReadLine());

            // MARK: Result
            var presidents = CalculatePresidents(input)
            Console.WriteLine($"You've voted for {presidents} presidents!");
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static int CalculatePresidents(int age)
        {
            return 0;
        }
    }
}