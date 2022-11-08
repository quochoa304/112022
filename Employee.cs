using System;
using System.Collections.Generic;
using System.Text;

namespace _25_10_2022
{
    class Employee : User, IEmployee
    {
        public int EmpID { get; set; }
        public String EmployeeName { get; set; }
        public String EmployeeGmail { get; set; }
        User users = new User();
        private static Employee emp = new Employee();
        public static List<Movie> moviesList = new List<Movie>();

        public Employee(String employeeName, String employeeGmail)
        {
            this.EmployeeName = employeeName;
            this.EmployeeGmail = employeeGmail;
        }

        public Employee()
        {

        }
        static public void displayEmployeeInformation()
        {
            Console.WriteLine("--------- ------Employee information------------------");
            Console.WriteLine("- Employee ID: {0}", emp.EmpID);
            Console.WriteLine("- Employee Name: {0}", emp.EmployeeName);
            Console.WriteLine("- Employee Gmail: {0}", emp.EmployeeGmail + "\n\n");
            Console.WriteLine("-----------------------------------------------------");
        }
        public void displayFilm()
            {
            Console.WriteLine("------------------------Hellooo: {0}--------------------\n", EmployeeName);
            if (Employee.moviesList.Count == 0)
            {
                Console.WriteLine("                    Film list is emty !!!\n");
                Console.WriteLine("--------------------------------------------------------\n\n");
            }
            else
            {
                Console.WriteLine("Film List:");
                for (int i = 0; i < Employee.moviesList.Count; i++)
                {
                    Console.WriteLine("Number {0}: ", i + 1);
                    Employee.moviesList[i].Display();
                }
            }

        }

        public void LoginAdmin()
        {
            var employees = new List<Employee>();
            Console.Clear();
            Console.Write("- Enter UserID: ");
            try
            {
                emp.EmpID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
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
                Console.Write("- Enter password: ");
                String epw = Console.ReadLine();
                Console.WriteLine("");
                if ((emp.EmpID == 1001 || emp.EmpID == 1002) && "admin" == epw)
                {
                    EmployeeCase();
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
        static void EmployeeCase()
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
                            inputMovie();
                            break;
                        case 2:
                            Console.Clear();
                            updateMovie();
                            break;
                        case 3:
                            Console.Clear();
                            displayEmployeeInformation();
                            break;
                        case 4:
                            Console.Clear();
                            emp.displayFilm(moviesList);
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
                EmployeeCase();
            }
        }

        static void EmployeeMenu()
        {
            Console.WriteLine("---- Employee menu ----");
            Console.WriteLine("1. Input movie\n2. Update movie\n3. Display profile\n4. Display movie\n0. Back\n");
            Console.Write("Your choose: ");
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
        static void inputMovie()
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
                    Employee.moviesList.Add(film);
                }
            }
            catch
            {
                Console.WriteLine("Please input a number ! ");
            }
        }
        static void updateMovie()
        {
            Console.WriteLine("What's movie of movie do you want to update? ");
            Console.Write("Input movie's name:  ");
            string searchh = Console.ReadLine();
            for (int i = 0; i < moviesList.Count; i++)
            {
                if (moviesList[i].Name.Equals(searchh))
                {
                    moviesList.RemoveAll(moviesList => moviesList.Name == searchh);
                    Movie film = new Movie();
                    film.Input();
                    moviesList.Add(film);
                }
                else
                {
                    Console.Write("Movie not found !  \n");
                }
            }
        }

    }
}
