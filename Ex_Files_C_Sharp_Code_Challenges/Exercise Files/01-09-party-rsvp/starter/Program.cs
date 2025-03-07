using System;
using System.Collections.Generic;

namespace partyrsvp
{
    class MainClass
    {
        static List<string> family = new List<string>() { "Harrison", "Kelsey", "Alex", "Haley" };
        static List<string> friends = new List<string>() { "James", "Hannah", "Kelly", "Alex" };
        static List<string> rsvp = new List<string>() { "Kelly", "Harrison" };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to see your party invite breakdown!");
            Console.ReadKey();

            // MARK: Result
            InviteDetails();
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void InviteDetails()
        {
            HashSet<string> allInvitees = new HashSet<string>(family);

            // Combine family and friends. HashSets cannot have duplicates, this will automatically remove them.
            allInvitees.UnionWith(friends);

            // Print out the total number of invites.
            Console.WriteLine($"You sent out {allInvitees.Count} invites!\n");

            Console.WriteLine($"Duplicates were sent to:");
            HashSet<string> duplicates = new HashSet<string>(family);

            // Find duplicates. IntersectWith will only keep the elements that are in both sets.
            duplicates.IntersectWith(friends);
            PrintSets(duplicates);

            Console.WriteLine("People who have not sent an RSVP:");
            // Finds elements that are present in the present object (everyone) or the specified (rsvp) object, but not in both.
            allInvitees.SymmetricExceptWith(rsvp);
            PrintSets(allInvitees);
        }

        // Handy helper to print out the data
        public static void PrintSets(HashSet<string> names)
        {
            int num = 1;
            foreach (string name in names)
            {
                Console.WriteLine($"  {num}. {name}");
                num++;
            }

            Console.WriteLine();
        }
    }
}
