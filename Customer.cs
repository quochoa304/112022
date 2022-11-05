using System;
using System.Collections.Generic;
using System.Text;

namespace _25_10_2022
{
    class Customer: User
    {
        public String Name  { get; set; }
        public String Phone { get; set; }
        private String Email { get; set; }
        private String Address { get; set; }
        User users = new User();
        public Order order;

        public Customer(String name, String phone, string email, string address)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
        }

        public Customer()
        {

        }
        public void displayFilm()
        {
            List<Movie> movies = new List<Movie>();
            Console.WriteLine("------------------------Hellooo: {0}--------------------\n", Name);
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
        public void login()
        {
            try
            {
                Console.WriteLine("Enter user ID: ");
                UserID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter password: ");
                Password = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("User ID must be a number !");
                login();
            }
        }
        public void Register()
        {
            try
            {
                Console.WriteLine("Enter user ID: ");
                UserID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter password: ");
                Password = Console.ReadLine();
                Console.Write("Input your name: ");
                Name = Console.ReadLine();
                Console.Write("Input phone number: ");
                Phone = Console.ReadLine();
                Console.Write("Input your email: ");
                Email = Console.ReadLine();
                Console.Write("Input address: ");
                Address = Console.ReadLine();
                Console.WriteLine("Sucessfully !");
            }
            catch
            {
                Console.WriteLine("User ID must be a number !");
                Register();
            }
        }
        public void addOrder()
        {
            Console.WriteLine("----------------Booking---------------");
            Console.Write("What's name of movie do you want to booking: ");
        }
        public virtual void CustomerInformation()
        {
            base.DisplayBooking();
            Console.WriteLine("Customer Name: {0}", Name);
            Console.WriteLine("Customer Gmail: {0}", Phone + "\n\n");
        }
        public override void InputBooking()
        {
            base.Display();
            Console.Write("Input your name: ");
            Name = Convert.ToString(Console.ReadLine());
            Console.Write("Input your phone number: ");
            Phone = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Added ticket ! ");
            Console.WriteLine("---------------------------------------");
        }
        public override void DisplayBooking()
        {
            if (Name == null)
            {
                Console.Write("Oh shiet");
            }
            else
            {
                base.DisplayBooking();
                Console.WriteLine("- Customer: " + Name);
                Console.WriteLine("- Phone number: " + Phone);
                Console.WriteLine("---------------------------------------");
            }
        }
    }


}
