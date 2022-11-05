using System;
using System.Collections.Generic;
using System.Text;

namespace _25_10_2022
{
    class User : Movie
    {
        public int UserID { get; set; }
        public String Password { get; set; }
        public void displayFilm(List<Movie> movies)
        {
            if (movies.Count == 0)
            {
                Console.WriteLine("---------------------------------------------------\n");
                Console.WriteLine("-            Film list is updating !!!            -\n");
                Console.WriteLine("---------------------------------------------------\n\n");
                Console.WriteLine("Your chosee: ");
            }
            else
            {
                Console.WriteLine("----------------------Film List----------------------");
                for (int i = 0; i < movies.Count; i++)
                {
                    Console.WriteLine("Number {0}: ", i + 1);
                    movies[i].Display();
                }
            }
            
        }

    }
}
