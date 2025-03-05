using System;
using System.Collections.Generic;
using System.Linq;

namespace seasonstats
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            List<int> scores = new List<int>();

            for(int i = 1; i < 4; i++)
            {
                Console.WriteLine($"How many points did you score in game #{i}?");
                int input = int.Parse(Console.ReadLine());
                scores.Add(input);
            }

            // MARK: Result
            PrintStats(scores);
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void PrintStats(List<int> scores)
        {
            
        }
    }
}