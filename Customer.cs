using System;
using System.Collections.Generic;
using System.Text;

namespace _25_10_2022
{
    class Customer : User
    {
        public String Name { get; set; }
        public String Phone { get; set; }
        private String Email { get; set; }
        private String Address { get; set; }
        public static List<Customer> CustomerList = new List<Customer>();
        public static List<Order> orders = new List<Order>();
        public static List<Seat> seatList = new List<Seat>();
        private static Order orderrs = new Order();

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
                if (Employee.moviesList.Count == 0)
                {
                    Console.WriteLine("---------------------------------------------------\n");
                    Console.WriteLine("-            Film list is updating !!!            -\n");
                    Console.WriteLine("---------------------------------------------------\n\n");
                    Console.WriteLine("Your chosee: ");
                }
                else
                {
                    Console.WriteLine("----------------------Film List----------------------");
                    for (int i = 0; i < Employee.moviesList.Count; i++)
                    {
                        Console.WriteLine("Number {0}: ", i + 1);
                        Employee.moviesList[i].Display();
                    }
                }
 
        }
        static void CustomerCase2()
        {
            int choose;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("---- Customer menu ----");
                Console.WriteLine("- 1. Display Movie\n- 2. Ticked booking\n- 3. Display ticked\n- 0. Back\nYour choose: ");
                var intAsString = Console.ReadLine();
                while (!int.TryParse(intAsString, out choose))
                {
                    Console.Clear();
                    Console.WriteLine("---- Customer menu ----");
                    Console.WriteLine("- 1. Display Movie\n- 2. Ticked booking\n- 3. Display ticked\n- 0. Back\nYour choose: ");
                    Console.WriteLine("(Please input a number!)");
                    intAsString = Console.ReadLine();
                }
                switch (choose)
                {
                    case 1:
                        Console.Clear();
                        Customer cus = new Customer();
                        cus.displayFilm();
                        break;
                    case 2:
                        Console.Clear();
                        addOrder();
                        break;
                    case 3:
                        Console.Clear();
                        orderrs.displayTicket();
                        break;
                    case 0:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Wrong input, please input again !");
                        break;
                }
            } while (choose != 0);
        }
        public void login()
        {
            try
            {
                Console.Write("- Enter user ID: ");
                int userID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("- Enter password: ");
                string password = Console.ReadLine();
                Console.WriteLine("");
                for (int i = 0; i < CustomerList.Count; i++)
                {
                    if (userID == CustomerList[i].UserID && password == CustomerList[i].Password)
                    {
                        CustomerCase2();
                    }
                }
            }
            catch
            {
                Console.WriteLine("User ID must be a number !");
            }

        }
        public void Register()
        {
            Customer cus = new Customer();
            Console.WriteLine("-------------Input information----------");
            try
            {
                Console.Write("- Enter user ID: ");
                cus.UserID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("- Enter password: ");
                cus.Password = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("- Input your name: ");
                cus.Name = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("- Input phone number: ");
                cus.Phone = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("- Input your email: ");
                cus.Email = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("- Input address: ");
                cus.Address = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Sucessfully !");
                Console.WriteLine("");
            }
            catch
            {
                Console.WriteLine("User ID must be a number !");
                Register();
            }
            CustomerList.Add(cus);
        }
        public void CustomerInformation(List<Customer>customers)
        {
                Console.WriteLine("- Customer ID: {0}", UserID);
                Console.WriteLine("- Customer Name: {0}", Name);
                Console.WriteLine("- Customer Gmail: {0}", Phone);
        }


        static public void addOrder()
        {
            Console.Write("Input your phone number: ");
            Order order = new Order();
            string sdt = Console.ReadLine();
            Console.WriteLine("");
            Customer customer = CustomerList.Find(r => r.Phone == sdt);
            for (int i = 0; i < CustomerList.Count; i++)
            {
                if (CustomerList[i].Phone.Equals(sdt))
                {
                    customer.CustomerInformation(CustomerList);
                    order.CustomerPhone = CustomerList[i].Phone;
                    order.CustomerName = CustomerList[i].Name;
                    Console.WriteLine("What movie do you want to book ?");
                    Console.Write("Input movie name: ");
                    string id = Console.ReadLine();
                    Console.WriteLine("");
                    Movie movie = Employee.moviesList.Find(r => r.Name == id);
                    for (int j = 0; j < Employee.moviesList.Count; j++)
                    {
                        if (Employee.moviesList[j].Name.Equals(id))
                        {
                            Console.WriteLine("----------------------Film List----------------------");
                            Employee.moviesList[j].Display();
                            order.Movie = movie;
                            order.Customer = customer;

                            Seat seat = new Seat();
                            seat.changeSeat();
                            order.Seat = seat;

                            orders.Add(order);
                            Console.WriteLine("Added ticked!");
                        }
                        else
                        {
                            Console.WriteLine("");
                        }
                    }

                }
                else
                {
                      Console.WriteLine("");
                }
            }
            
        }
    }


}
