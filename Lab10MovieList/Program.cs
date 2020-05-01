using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Lab10MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movie = new List<Movie>();
            FillListOfMovies(movie);

            Console.WriteLine("\tWelcome");
            Console.WriteLine("please choose a movie category \nenter: ");
            Console.WriteLine("(1) for Animated \n(2) for Drama\n(3) for Horror\n(4) for Scifi");
            string userInput = Console.ReadLine();
            //I'm lost on how to keep refrencing to methods and classes and going between both :(




            
        }
        public static void FillListOfMovies(List<Movie> movie)
        {
            movie.Add(new Movie("Star Wars", "4"));
            movie.Add(new Movie("Edward Scissor Hands", "2"));
            movie.Add(new Movie("Jason", "3"));
            movie.Add(new Movie("Walace and Gromit", "1"));
            movie.Add(new Movie("Space Oddesy 2001", "4"));
            movie.Add(new Movie("Frozen", "1"));
            movie.Add(new Movie("Hellraiser", "3"));
            movie.Add(new Movie("Lion King", "1"));
            movie.Add(new Movie("My Girl", "2"));
            movie.Add(new Movie("Pitch Black", "4"));

          
        }

        //string userInput = "scifi";
        //    Dictionary<string, string> films = new Dictionary<string, string>();
        //    films.Add("Walace and Gromit", "animated");
        //    films.Add("Star Wars", "scifi");
        //    films.Add("Edward Scissor Hands", "drama");
        //    films.Add("Jason", "horror");
        //    films.Add("Space Oddesy 2001", "scifi");
        //    films.Add("Frozen", "animated");
        //    films.Add("Hellraiser", "horror");
        //    films.Add("Lion King", "animated");
        //    films.Add("My Girl", "drama");
        //    films.Add("Pitch Black", "scifi");

        //foreach (string key in films.Keys)
        //    {
        //        string genre = films[key];
        //        if (genre == userInput)
        //        {
        //            Console.WriteLine(key);
        //        }






    }
    
}

    

