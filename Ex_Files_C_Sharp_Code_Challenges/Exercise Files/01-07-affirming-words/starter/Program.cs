using System;
using System.Collections.Generic;
using System.Timers;

namespace affirmingwords
{
    class MainClass
    {
        static Random random = new Random();
        static List<string> encouragements = new List<string>()
        {
            "Way to go!",
            "Keep it up!",
            "Almost there!",
            "You're doing great!"
        };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to start the timer!");
            Console.ReadLine();

            // MARK: Result
            StartTimer(3);

            Console.WriteLine("You can end the timer anytime by pressing ENTER.\n");
            Console.ReadLine();
            StopTimer();
        }

        // MARK: Write your solution here...

        private static Timer timer;

        public static void StartTimer(int interval)
        {
            if (timer == null) {

                timer = new Timer();
                timer.Interval = interval * 1000;   // Set interval to seconds
                timer.AutoReset = true;
                timer.Enabled = true;

                int elapsedTime = 0;
                timer.Elapsed += (sender, e) =>
                {
                    elapsedTime += interval; // Convert milliseconds to seconds
                    Console.WriteLine($"{elapsedTime} seconds: {encouragements[random.Next(encouragements.Count)]}");
                };

            }
        }

        public static void StopTimer()
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();

                Console.WriteLine("Timer stopped.");
            }

        }
    }
}