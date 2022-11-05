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
        public Employee(String employeeName, String employeeGmail)
        {
            this.EmployeeName = employeeName;
            this.EmployeeGmail = employeeGmail;
        }

        public Employee()
        {

        }
        public virtual void displayEmployeeInformation()
        {
            Console.WriteLine("Employee ID: {0}", EmpID);
            Console.WriteLine("Employee Name: {0}", EmployeeName);
            Console.WriteLine("Employee Gmail: {0}", EmployeeGmail + "\n\n");
        }
        public void displayFilm(List<Movie> movies)
            {
            Console.WriteLine("------------------------Hellooo: {0}--------------------\n", EmployeeName);
            if (movies.Count == 0)
            {
                Console.WriteLine("                    Film list is emty !!!\n");
                Console.WriteLine("--------------------------------------------------------\n\n");
            }
            else
            {
                Console.WriteLine("Film List:");
                for (int i = 0; i < movies.Count; i++)
                {
                    Console.WriteLine("Number {0}: ", i + 1);
                    movies[i].Display();
                }
            }

        }



    }
}
