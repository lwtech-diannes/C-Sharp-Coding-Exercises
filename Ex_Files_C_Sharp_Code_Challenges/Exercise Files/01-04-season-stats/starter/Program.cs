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
            int avg = 0;
            int highest = 0;
            int lowest = 0;
            int total = 0;
            int numScores = scores.Count;

            foreach (int i in scores) {
                if (i > highest)
                {
                    highest = i;
                }
                if (highest > i)
                {
                    lowest = i;
                }
                total += i;
            }

            avg = total / numScores;

            Console.WriteLine($"Lowest scoring game --> { lowest }");
            Console.WriteLine($"Highest scoring game --> { highest }");
            Console.WriteLine($"Total season points --> { total }");
            Console.WriteLine($"Average points per game --> { avg }");
        }
    }
}