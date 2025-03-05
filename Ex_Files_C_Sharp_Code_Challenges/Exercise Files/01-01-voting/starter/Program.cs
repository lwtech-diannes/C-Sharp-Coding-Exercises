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
            var presidents = CalculatePresidents(input);
            Console.WriteLine($"You've voted for {presidents} presidents!");
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static int CalculatePresidents(int age)
        {
            int votes = 0;
            int votingAgeRange = 0;
            if (age < 18)
            {
                Console.WriteLine("Whoops! You are not old enough to vote.");
                votes = 0;
            }
            else if (age >= 18)
            {
                   votingAgeRange = age - 18;
                   votes = votingAgeRange / 4;
            }
            return votes;
        }
    }
}