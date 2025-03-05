using System;

namespace decomposingurls
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            string exampleURL = "www.docs.microsoft.com/dotnet/csharp/whats-new/csharp-version-history";
            Console.WriteLine($"Hit ENTER to break down the URL into its component parts: {exampleURL}");
            Console.ReadKey();

            // MARK: Result
            var components = BreakdownURL(exampleURL);
            for (int i = 0; i < components.Length; i++)
            {
                var indent = new string(' ', i * 2);
                Console.WriteLine($"{indent} -> {components[i]}");
            }
        }

        // MARK: Calculation

        /* Requirements: 
         * - Remove the 'www.' from the beginning
         * - Replace any '-' with a blank space
         * - Split the URL at each '/' character
         */

        public static string[] BreakdownURL(string urlString)
        {
            string removeWWW = urlString.Remove(0, 4);

            string replaceDashes = removeWWW.Replace("-", " ");

            string[] components = replaceDashes.Split('/');

            return components;
        }
    }
}