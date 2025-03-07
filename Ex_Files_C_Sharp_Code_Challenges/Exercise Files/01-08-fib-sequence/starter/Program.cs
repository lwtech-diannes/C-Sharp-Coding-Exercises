using System;
using System.Collections.Generic;

namespace fibsequence
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the number of Fibonacci elements you'd like to calculate:");
            int input = int.Parse(Console.ReadLine());

            // MARK: Result
            var sequence = CalculateFibonacci(input);
            foreach (var fibonacci in sequence)
            {
                Console.WriteLine(fibonacci);
            }

            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static List<int> CalculateFibonacci(int length)
        {
            List<int> sequence = new List<int>();

            int first = 0;
            int second = 1;
            sequence.Add(first);
            sequence.Add(second);

            while (length > 2) {
                int next = first + second; // Add the first and second numbers together to create the next number in the sequence
                sequence.Add(next);        // Add that number to the sequence
                first = second;            // The second number moves into the first postion, so that it can be added to the "next" number
                second = next;             // The previously calculated "next" number moves into the second position. The loop restarts with the 
                                           // values of the new first and second numbers. 
                length--;
            }
            return sequence;
        }
    }
}