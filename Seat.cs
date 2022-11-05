using System;
using System.Collections.Generic;
using System.Text;

namespace _25_10_2022
{
    class Seat : Order
    {
        private string seatRow { get; set; }
        private string seatCollum { get; set; }
        private string seatType { get; set; }
        public Seat()
        {

        }

        public Seat(string seatrow, string seatcollum, string seattype)
        {
            this.seatRow = seatrow;
            this.seatCollum = seatcollum;
            this.seatType = seattype;
        }

        public void changeSeat()
        {
            Console.Write("Please choose a seat ! \n-------------------------");
            Console.Write("\nRow    |     A B C D E F");
            Console.Write("\nCollum |     1 2 3 4 5 6\n-------------------------");
            Console.Write("\nInput row: ");
            seatRow = Console.ReadLine();
            Console.Write("\nInput collum: ");
            seatCollum = Console.ReadLine();
            Console.WriteLine("Added seat !");
            //Set value to seatType
            if (seatRow == "C")
            {
                seatType = "SSVIP"; 
            } 
            else if (seatRow == "D")
                    {
                        seatType = "VIP"; 
                    } else 
                        {
                            seatType = "Normal"; 
                        }

        }
        public virtual void Display(List<Seat>seats)
        {
            Console.WriteLine("- Seat row: {0}                 ", seatRow);
            Console.WriteLine("- Seat collum: {0}     ", seatCollum);
            Console.WriteLine("- Seat type: {0}                ", seatType);
            Console.WriteLine("----------------------------------------");
        }

    }
    
}
