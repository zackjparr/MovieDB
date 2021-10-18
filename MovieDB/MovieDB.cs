using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDBProject
{
    class MovieDB
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public MovieDB()
        {
            Movies.Add(new Movie("Akira", "animated"));
            Movies.Add(new Movie("Cloudy With A Chance of Meatballs", "animated"));
            Movies.Add(new Movie("A Goofy Movie", "animated"));
            Movies.Add(new Movie("The Lobster", "drama"));
            Movies.Add(new Movie("Her", "drama"));
            Movies.Add(new Movie("Black Swan", "drama"));
            Movies.Add(new Movie("Godzilla", "scifi"));
            Movies.Add(new Movie("Blade Runner 2049", "scifi"));
            Movies.Add(new Movie("Pitch Black", "scifi"));
            Movies.Add(new Movie("The Witch", "horror"));
            Movies.Add(new Movie("Hereditary", "horror"));
            Movies.Add(new Movie("Evil Dead", "horror"));
            //Movies.Sort(x => x.Title);
        }

        public void UserSelection()
        {
            Console.WriteLine("Welcome to Zack's_Movie_World.net!");
            string userSelect = GetUserInput("Please select a catergory:\n1) animation\n2) drama\n3) horror\n4) scifi").ToLower().Trim();

            if (userSelect == "animated" || userSelect == "drama" || userSelect == "horror" || userSelect == "scifi")
            {
                PrintMovie(userSelect);
            }
            else if (userSelect == "1")
            {
                PrintMovie("animated");
            }
            else if (userSelect == "2")
            {
                PrintMovie("drama");
            }
            else if (userSelect == "3")
            {
                PrintMovie("horror");
            }
            else if (userSelect == "4")
            {
                PrintMovie("scifi");
            }
            else
            {
                Console.WriteLine("Please select a valid category");
                UserSelection();
            }
        }

        public void PrintMovie(string input)
        {

            for (int i = 0; i < Movies.Count; i++)
            {
                Movie Film = Movies[i];
                if (input.ToLower() == Film.Category.ToLower())
                {
                    Console.WriteLine(Film.Title);
                }
            }
        }

        public string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();

            return input;
        }
    }
}
