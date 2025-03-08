using System;

namespace tipcalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the cost of your meal to calculate tip options:");
            var input = int.Parse(Console.ReadLine());

            // MARK: Result
            CalculateTip(input);
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void CalculateTip(int cost)
        {
            var tips = Tuple.Create(0.10, 0.175, 0.25);

            Console.WriteLine($"Tip options: \n\t10% -> {(cost * tips.Item1):C} \n\t17.5% -> {(cost * tips.Item2):C} \n\t25 % -> {(cost* tips.Item3):C}");
        }
    }
}
