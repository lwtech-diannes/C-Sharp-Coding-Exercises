using System;
using System.Collections.Generic;

namespace countingvowels
{
    class MainClass
    {
        public static Dictionary<char, int> vowelScores = new Dictionary<char, int>()
        {
            { 'a', 1 },
            { 'e', 2 },
            { 'i', 3 },
            { 'o', 4 },
            { 'u', 5 },
            { 'y', 9 }
        };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Type in a word or phrase to find it's vowel score:");
            string input = Console.ReadLine().ToLower();

            // MARK: Result
            VowelCount(input);
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void VowelCount(string text)
        {

        }
    }
}