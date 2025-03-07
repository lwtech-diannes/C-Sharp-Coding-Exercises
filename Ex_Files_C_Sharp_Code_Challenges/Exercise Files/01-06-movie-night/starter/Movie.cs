using System;
namespace movienight
{
    // MARK: Write your solution in this class
    public class Movie
    {
        public string title;
        public string rating;
        public int reviewScore;

        public Movie(string title, string rating, int score)
        {
            this.title = title;
            this.reviewScore = score;
            this.rating = rating;
        }

        public override string ToString() { 
            
            string description = $"Title: { title } \nRating: { rating } \nRT Review Score: { reviewScore }";

            // Could make a bool constant instead
            if (reviewScore > 75) { 
                
                description += " <-- Certified Fresh!";
            }
            return description;
        }
    }
}