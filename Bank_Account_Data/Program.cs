using System;

namespace MyProject
{
    public class Person
    {
        // First name
        // Last name
        // Age (0...100)
        // Gender (m or f)
        // Personal ID number (e.g. 8306112507)
        // Unique employee number (27560000…27569999)
        public string firstName;
        public string middleName;
        public string lastName;
        public string bankName;
        public double balance = 2564.333;
        public string IBAN;
        public string[] creditCards;

        public double getBalance
        {
            get
            {
                return balance;
            }
        }

        public void deposit(double addAmt)
        {
            balance += addAmt;
        }

        public bool withdraw(double outAmt)
        {
            bool chk = true;
            if (outAmt <= balance)
            {
                balance -= outAmt;
            }
            else if (outAmt > balance)
            {
                chk = false;
            }
            return chk;
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firstName = "Martin";
            person.middleName = "Marianov";
            person.lastName = "Petrakiev";
            person.withdraw(1000);
            person.bankName = "AmericanExpress";
            person.IBAN = "DE97512305024500160900";
            person.creditCards = new string[3] { "1234432112344321", "5678876556788765", "9090123490901234" };
            Console.WriteLine(person.firstName + " " + person.lastName);
            Console.WriteLine(person.getBalance);
        }
    }
}