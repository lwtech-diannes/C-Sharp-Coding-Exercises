using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace gamenight
{
    class MainClass
    {
        public static List<Player> players = new List<Player>()
        {
            new Player("Harrison", "Ferrone", 233, 198),
            new Player("Alex", "Ferrone", 219, 202),
            new Player("Haley", "Ferrone", 241, 222),
            new Player("John", "Doe", 144, 198),
            new Player("Sally", "Doe", 233, 198),
            new Player("Frank", "Smith", 189, 234),
            new Player("Joan", "Smith", 211, 178)
        };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter an improvement index to see which game night attendees fit the bill:");
            var targetImprovement = int.Parse(Console.ReadLine());

            // MARK: Result
            PrintStats(targetImprovement);
            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static void PrintStats(int targetImprovement)
        {
            var gameQuery =

                from player in players
               
                let improvement = player.currentScore - player.lastScore
                
                where improvement > targetImprovement && improvement > 0
                
                group player by player.lastname[0] into playerGroup
              
                orderby playerGroup.Key
              
                select playerGroup;

            foreach (var playerGroup in gameQuery)
            {
                Console.WriteLine("\n" + playerGroup.Key);
                foreach (var player in playerGroup)
                {
                    Console.WriteLine($"{player.firstname} {player.lastname} improved by more than {targetImprovement}!");
                }
            }
        }
    }
}