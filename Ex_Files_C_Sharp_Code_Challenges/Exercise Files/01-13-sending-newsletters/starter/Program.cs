using System;
using System.Collections.Generic;
using System.Text.Json;

namespace sendingnewsletters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
                        // MARK: Setup
            string jsonString =
            @"{
              ""Name"": ""Weekly Comics Newsletter!"",
              ""Admin"": ""Jane Porter"",
              ""CreatedOn"": ""2022-01-01"",
              ""Subscribers"": [
                {
                  ""Name"": ""Jack Powell"",
                  ""ID"": 231,
                  ""Email"": ""jpowell0@hplussport.com""
                },
                {
                  ""Name"": ""Emily Garcia"",
                  ""ID"": 221
                },
                {
                  ""Name"": ""Richard Dean"",
                  ""ID"": 211
                },
                {
                  ""Name"": ""Jane Larson"",
                  ""ID"": 201,
                  ""Email"": ""jlarsone@hplussport.com""  
                }
              ]
            }";

            Console.WriteLine("Hit ENTER to find out who's missing an email!");

            // MARK: Result
            var customerIDs = DecryptJSON(jsonString);
            foreach (var id in customerIDs)
            {
                Console.WriteLine($"\nSend missing info prompt to user ID: {id}");
            }

            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static List<int> DecryptJSON(string json)
        {
            return new List<int>();
        }
    }
}
