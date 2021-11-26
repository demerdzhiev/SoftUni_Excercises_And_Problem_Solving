using System;

namespace T05._MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int movies = int.Parse(Console.ReadLine());
            double lowestRating = 10;
            double highestRating = 0;
            string movieWithLowestRating = "";
            string movieWithHighestRating = "";
            double averageRating = 0;



            for (int i = 0; i < movies; i++)
            {
                string movieName = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                averageRating += rating;

                if (rating >= highestRating)
                {
                    highestRating = rating;
                    movieWithHighestRating = movieName;
                }
                if (rating <= lowestRating)
                {
                    lowestRating = rating;
                    movieWithLowestRating = movieName;
                }



            }
            Console.WriteLine($"{movieWithHighestRating} is with highest rating: {highestRating:f1}");
            Console.WriteLine($"{movieWithLowestRating} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {averageRating / movies:f1}");

        }
    }
}
