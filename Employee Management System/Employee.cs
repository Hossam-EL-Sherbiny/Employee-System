using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Employee_Management_System
{
    public class Employee
    {
        // Private Fields
        private readonly string name;
        private string address;
        private double salary;
        private string department;
        private readonly int id;

        // Constructos initialization..
        public Employee(string employeeName, string address, double salary, string department, int id)
        {
            this.name = employeeName;
            this.address = address;
            this.salary = salary;
            this.department = department;
            this.id = id;   
        }

        // Method to add..
        public void UpdateAddress(string newAddress)
        {
            address = newAddress;
            Console.WriteLine("Address Updated.");
        }

        public void UpdateSalary(double newaSalary)
        {
            this.salary = newaSalary;
            Console.WriteLine("Salary Updated Successfuly");
        }

        public void UpdateDepartment(string newDepartment)
        {
            department = newDepartment;
            Console.WriteLine("Department Updated Successfuly");
        }

        public void Delete()
        {
            Console.WriteLine("Employee Data Deleted Successfuly");
        }

        public void Display()
        {
            Console.WriteLine("Employee Id: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Department: " + department);
            Console.WriteLine();
        }
    }
}