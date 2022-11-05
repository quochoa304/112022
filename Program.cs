using System;
using System.Collections.Generic;

namespace _25_10_2022
{
    class Program
    {
        private static List<Employee> employees;
        private static Employee emp = new Employee();
        private static List<Movie> movies;
        private static List<Seat> seats;
        private static Customer cus = new Customer();


        static void Main(string[] args)
        {
            MenuCase();
        }
        static void Menu()
        {
            Console.WriteLine("------------WUOC HOA CINEMA------------");
            Console.WriteLine("Are you an employee or a customer?");
            Console.WriteLine("1. Employee");
            Console.WriteLine("2. Customer");
            Console.WriteLine("3. Display flim list");
            Console.WriteLine("0. Exit");
            Console.WriteLine("---------------------------------------");
            Console.Write("Your choose: ");
        }
        static void EmployeeMenu()
        {
            Console.WriteLine("---- Employee menu ----");
            Console.WriteLine("1. Input movie\n2. Update movie\n3. Display profile\n4. Display movie\n0. Back\n");
            Console.Write("Your choose: ");
        }

        static void CustomerMenu1()
        {
            Console.WriteLine("------- Customer menu -------");
            Console.WriteLine("1. Login\n2. Register\n0. Back\nYour choose: ");
        }
        static void CustomerMenu()
        {
            Console.WriteLine("---- Customer menu ----");
            Console.WriteLine("1. Display Movie\n2. Search movie by name\n3. Search by author\n4. Booking a movie\n0. Back\nYour choose: ");
        }
        static void MenuCase()
        {
            List<Movie> movies = new List<Movie>();
            List<Customer> customer = new List<Customer>();
            Menu();
            int choose;
            do
            {
                var intAsString = Console.ReadLine();
                while (!int.TryParse(intAsString, out choose))
                {
                    Console.Clear();
                    Menu();
                    Console.WriteLine("(Please input a number!)");
                    intAsString = Console.ReadLine();
                }
                switch (choose)
                {
                    case 1:
                        LoginAdmin(movies);
                        break;
                    case 2:
                        Console.Clear();
                        CustomerCase1(movies);
                        break;
                    case 3:
                        User user = new User();
                        user.displayFilm(movies);
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Goodbye !");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Wrong input, please input again !");
                        break;
                }
            } while (choose != 0);
        }
        static void EmployeeCase(List<Movie> movies)
        {
            int choose;
            try 
            {
                do
                {
                    EmployeeMenu();
                    choose = Convert.ToInt32(Console.ReadLine());

                    switch (choose)
                    {
                        case 1:
                            Console.Clear();
                            inputMovie(movies);
                            break;
                        case 2:
                            Console.Clear();
                            updateMovie(movies);
                            break;
                        case 3:
                            Console.Clear();
                            displayEmployeeInformation(employees);
                            break;
                        case 4:
                            Console.Clear();
                            emp.displayFilm(movies);
                            break;
                        case 0:
                            Console.Clear();
                            Menu();
                            break;
                        default:
                            Console.WriteLine("Wrong input, please input again !");
                            break;
                    }
                } while (choose != 0);
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Wrong input, please input a number !");
                EmployeeCase(movies);
            }
        }

        static void CustomerCase1(List<Movie> movies)
        {
            var customer = new List<Customer>();
            int choose;
            do
            {
                CustomerMenu1();
                var intAsString = Console.ReadLine();
                while (!int.TryParse(intAsString, out choose))
                {
                    Console.Clear();
                    Menu();
                    Console.WriteLine("(Please input a number!)");
                    intAsString = Console.ReadLine();
                }
                switch (choose)
                {
                    case 1:                         //login
                        Console.Clear();
                        Customer cus = new Customer();
                        cus.login();
                        for (int i = 0; i < customer.Count; i++)
                        {
                            if (cus.UserID == customer[i].UserID && cus.Password == customer[i].Password)
                            {
                                CustomerCase2(customer);
                            }
                        }
                        break;
                    case 2:                         //Register
                        Console.Clear();
                        register(customer);
                        break;
                    case 0:
                        Console.Clear();
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Wrong input, please input again !");
                        break;
                }
            } while (choose != 0);
        }

        static void CustomerCase2(List<Customer> customer)
        {
            List<Order> orders = new List<Order>();
            var seats = new List<Seat>();
            int choose;
            do
            {
                CustomerMenu();
                var intAsString = Console.ReadLine();
                while (!int.TryParse(intAsString, out choose))
                {
                    Console.Clear();
                    CustomerMenu();
                    Console.WriteLine("(Please input a number!)");
                    intAsString = Console.ReadLine();
                }
                switch (choose)
                {
                    case 1:
                        Console.Clear();
                        Customer customers = new Customer();
                        customers.displayFilm(movies);
                        break;
                    case 2:
                        Console.Clear();
                        cus.addOrder();
                        inputSeat(seats);
                        InputBooking(customer);
                        break;
                    case 3:
                        Console.Clear();
                        DisplayBooking(orders);
                        DislpaySeat(seats);
                        displayCustomerInformation(customer);
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
        static void InputBooking(List<Customer> customers)
        {
            List<Seat> seats = new List<Seat>();
            string search = Console.ReadLine();
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Name.Equals(search))
                {
                    customers[i].InputBooking();
                    inputSeat(seats);
                }
            }
        }





        static void displayCustomerInformation(List<Customer> customer)
        {
            Console.WriteLine("----------------Ticket---------------");
            for (int i = 0; i < customer.Count; i++)
            {
                customer[i].CustomerInformation();
            }
        }
        static void DisplayBooking(List<Order> orders)
        {
            Console.WriteLine("----------------Ticket---------------");
            for (int i = 0; i < orders.Count; i++)
            {
                orders[i].pllaceOrder(seats);
            }
        }
        static void DislpaySeat(List<Seat> seats)
        {
                Console.Clear();
                Order order = new Order();
                order.pllaceOrder(seats);
        }

        static void LoginAdmin(List<Movie> movies)
        {
            var employees = new List<Employee>();
            Console.Clear();
            Console.WriteLine("Enter UserID: ");
            try
            {
                emp.EmpID = Convert.ToInt32(Console.ReadLine());
                if (emp.EmpID == 1001)
                {
                    emp.EmployeeName = "Hoa";
                    emp.EmployeeGmail = "Hoa@gmail";
                }
                else if (emp.EmpID == 1002)
                {
                    emp.EmployeeName = "Khoa";
                    emp.EmployeeGmail = "Khoaaaaa@gmail";
                }
                employees.Add(emp);
                Console.WriteLine("Enter password: ");
                String epw = Console.ReadLine();
                if ((emp.EmpID == 1001 || emp.EmpID == 1002) && "admin" == epw)
                {
                    EmployeeCase(movies);
                }
                else
                {
                    Console.WriteLine("Wrong User ID or password, please check again !");
                    Console.WriteLine("Press ENTER to return main menu...");
                    Console.ReadLine();
                    Console.Clear();
                    Menu();
                }
            }
            catch (Exception loi)
            {
                Console.WriteLine("Please input a number for User ID !");
                Console.WriteLine("Press ENTER to return main menu...");
                Console.ReadLine();
                Console.Clear();
                Menu();
            }
        }

        static void inputMovie(List<Movie> movies)
        {
            try
            {
                Console.WriteLine("How many films you want to input ? ");
                int n = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("-------------Input film information----------", i + 1);
                    Movie film = new Movie();
                    film.Input();
                    movies.Add(film);
                }
            }
            catch
            {
                Console.WriteLine("Please input a number ! ");
            }
        }
        static void inputSeat(List<Seat> seats)
        {
                    Console.WriteLine("-------------Input film information----------");
                    Seat seat = new Seat();
                    seat.changeSeat();
                    seats.Add(seat);
        }

        private static void register(List<Customer> customer)
        {

            Console.WriteLine("-------------Input information----------");
            Customer cus = new Customer();
            cus.Register();
            customer.Add(cus);
        }

        static void displayFilm(List<Movie> movies)
        {
            Console.WriteLine("---------------------------------------------------------");
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine("Number {0}: ", i + 1);
                movies[i].Display();
            }
        }
        static void updateMovie(List<Movie> movies)
        {
            Console.WriteLine("What's movie of movie do you want to update? ");
            Console.Write("Input movie's name:  ");
            string searchh = Console.ReadLine();
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Name.Equals(searchh))
                {
                    movies.RemoveAll(movies => movies.Name == searchh);
                    Movie film = new Movie();
                    film.Input();
                    movies.Add(film);
                }
                else
                {
                    Console.Write("Movie not found !  \n");
                }
            }
        }
        static void displayEmployeeInformation(List<Employee> employees)
        {
            Console.WriteLine("----------------------------------------");
            emp.displayEmployeeInformation();
        }
        static void SearchByName(List<Movie> movies)
        {
            Console.WriteLine("What's name of movie do you want to search? ");
            Console.Write("Input name:  ");
            string searchh = Console.ReadLine();
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Name.Equals(searchh))
                {
                    Console.WriteLine("-------------Film information----------");
                    movies[i].Display();
                }
            }
        }


        static void Cancellation(List<Order> orders)
        {
            Console.Write("Input your phone number: ");
            string a = Console.ReadLine();
            Console.WriteLine("|----------------------------|");
            Console.WriteLine("|----- Ticket canceled! -----|");
            Console.WriteLine("|----------------------------|");
        }



    }
}
