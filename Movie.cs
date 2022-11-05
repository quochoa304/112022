using System;
using System.Collections.Generic;
using System.Text;

namespace _25_10_2022
{
    class Movie
    {
            public string Name { get; set; }
            private string Author { get; set; }
            private string Producer { get; set; }
            private string Year { get; set; }

            public Movie()
            {

            }

            public Movie(String name, string author, string producer, string year)
            {
                this.Name = name;
                this.Author = author;
                this.Producer = producer;
                this.Year = year;
            }
        List<Movie> movies = new List<Movie>();
        public void Input()
         {
            Console.Write("Input film name: ");
            Name = Console.ReadLine();
            Console.Write("Input directors: ");
            Author = Console.ReadLine();
            Console.Write("Film Production Corporation: ");
            Producer = Console.ReadLine();
            Console.Write("Showtimes: ");
            Year = Console.ReadLine();
            Console.WriteLine("Added film !");

        }
        public virtual void Display()
            {
                Console.WriteLine(" - Name of film: {0}                   ", Name);
                Console.WriteLine(" - Name of directors: {0}                 ", Author);
                Console.WriteLine(" - Film Production Corporation: {0}     ", Producer);
                Console.WriteLine(" - Showtimes: {0}                ", Year);
                Console.WriteLine("------------------------------------------------------");
            }


        public virtual void InputBooking()
        {

        }

        public virtual void DisplayBooking()
        {
            Display();
        }
    }
    }

