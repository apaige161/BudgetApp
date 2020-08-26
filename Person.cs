using System;

namespace addressBookLibrary.Shared
{
    //The goal is to make a budgeting app using a library
    public class Person : Object
    {
        //fields
        public string FirstName;
        public string LastName;
        public DateTime DateCreated;

        //constructor
        public Person()
        {
            //set of default values
            FirstName = "Generic first name";
            LastName = "Generic last name";
            DateCreated = DateTime.Now;
        }

        //methods
        public void WriteToConsole() //void method, does something
        {
            Console.WriteLine($"{FirstName} {LastName} was created on {DateCreated:dddd}");
        }
        
    }

    public class BankAccount
    {
        //store information about money

        public decimal Balance;
        public static decimal InterestRate; //shared member
    }
}
