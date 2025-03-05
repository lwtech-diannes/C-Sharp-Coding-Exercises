using System;

namespace validatingemails
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the email address you'd like to validate:");
            var input = Console.ReadLine();

            // MARK: Result
            ValidateEmail(input);
            Console.ReadKey();
        }

        // MARK: Write your solution here
        /* Requirements: 
            - Must contain an '@' symbol
            - Must end in .com
            - 1st character cannot be a number or a symbol
            - Display success message if email is valid
            - Display error message if email is invalid
            - Display error message if email is valid
        */
        public static void ValidateEmail(string email)
        {
            if (char.IsDigit(email[0]) || char.IsSymbol(email[0]))
            {
                Console.WriteLine("Email is invalid. First character cannot be a number or symbol.");
            }
            else if (!email.Contains("@"))
            {
                Console.WriteLine("Email is valid. Please include the '@' symbol.");
            }
            else if (!email.EndsWith(".com")) 
            {
                Console.WriteLine("Email is valid. Your email must end in '.com'.");
            }
            else
            {
                Console.WriteLine("Email is valid.");
            }
        }
    }
}