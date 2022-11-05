using System;
using System.Collections.Generic;
using System.Text;

namespace _25_10_2022
{
    interface IEmployee
    {
        void displaSeat(List<Seat> seats)
        {
            Order order = new Order();
            order.pllaceOrder(seats);
        }

    }
}
