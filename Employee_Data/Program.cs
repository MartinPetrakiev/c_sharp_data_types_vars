using System;

namespace MyProject
{
    class Employee
    {
        // First name
        // Last name
        // Age (0...100)
        // Gender (m or f)
        // Personal ID number (e.g. 8306112507)
        // Unique employee number (27560000…27569999)
        string firstName;
        string lastName;s
        int age;
        string gender;
        int personalID;
        int uniqueEmployeeID;
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Martin";
            employee.lastName = "Petrakiev";
            employee.age = 25;
            employee.gender = "m";
            employee.personalID = 1234567891;
            employee.uniqueEmployeeID = 12345678;
            Console.Write(employee.firstName + " " + employee.lastName);
        }
    }
}
