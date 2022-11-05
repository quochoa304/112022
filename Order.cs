using System;
using System.Collections.Generic;
using System.Text;

namespace _25_10_2022
{
    class Order : Customer
    {
        public int OrderID { get; set; }
        Seat seat;
        List<Movie> movies;
        List<Seat> seats;
        public string CustomerName {get;set;}
        public string CustomerPhone { get; set; }

        public Order(string name, string author, string producer, string year, string cname, string sdt)
        : base(name, author, producer, year)
        {
            CustomerName = name;
            CustomerPhone = sdt;
        }

        public Order()
        {
        }

        public void pllaceOrder(List<Seat> seats) 
        {
           Console.WriteLine("Order Detail:");
            if (CustomerName == null)
            {
                Console.Write("");
            }
            else
            {
                base.DisplayBooking();
                Console.WriteLine("- Customer: " + CustomerName);
                Console.WriteLine("- Phone number: " + CustomerPhone);
                Console.WriteLine("---------------------------------------");
            }
            for (int i = 0; i < seats.Count; i++)
            {
                seats[i].Display(seats);
            }

        }
    }
}
