using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGitHub
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public int age;
        public string position;
        public string city;
        public string department;

        public Employee(string employeeName, 
            string employeeLastName,
            int employeeAge,
            string employeePosition,
            string employeeCity,
            string employeeDepartment)
        {
            firstName = employeeName;
            lastName = employeeLastName;    
            age = employeeAge;
            position = employeePosition;
            city = employeeCity;
            department = employeeDepartment;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Hello! I am {firstName} {lastName}, from {city}.\nI am {age} years old and working as {position} in {department}");
        }

    }
}
