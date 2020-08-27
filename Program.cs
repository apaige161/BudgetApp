using System;
using static System.Console;
using addressBookLibrary.Shared;

namespace BudgetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to the simple budgeting app!");

            //instantiate the user
            var person = new Person();
            WriteLine("What is your first name?");
            person.FirstName = ReadLine();
            WriteLine("What is your last name?");
            person.LastName = ReadLine();
            
            
            if(person.FirstName != null && person.LastName != null)
            {
                WriteLine($"Welcome {person.FirstName} {person.LastName} \n \n What Can I do For You? \n");
            }
            else
            {
                WriteLine("You must have a name right?!?");
            }

            //options total up pay, total up bills, total left over
            //add more options later
            string[] options = {
                "Total up monthly pay and bills"
            };
            
            //loop through options
            for(int i = 0; i < options.Length; i++)
            {
                WriteLine($"{i + 1}). {options[i]}");
            }
            
            //collect user input
            int userOption = Convert.ToInt32(ReadLine());
            WriteLine(options[userOption - 1]);


            //print list of bills
            string[] ListOfBills = {
                "Rent/Mortgage",
                "Elcetric",
                "Natural Gas",
                "Water/Trash",
                "Car Insurance",
                "Groceries",
                "Phone",
                "Internet and/or Cable",
                "Other (Includes any expenses for pets, dependants, etc"
            };

            //collect user data for total spent on bills
            WriteLine("Enter the amount paid on average per month of each item");
            decimal billTotal = default;
            foreach(var bill in ListOfBills)
            {
                Write($"{bill}: ");
                billTotal += Convert.ToDecimal(ReadLine());
            }
            WriteLine($"{billTotal:C}");

            string[] listOfIncomes ={
                "Primary Job",
                "Secondary Job",
                "Passive Income"
            };

            //collect user data for total spent on bills
            WriteLine("Enter the amount paid on average per month of each item");
            decimal incomeTotal = default;
            foreach(var income in listOfIncomes)
            {
                Write($"{income}: ");
                incomeTotal += Convert.ToDecimal(ReadLine());
            }
            WriteLine($"{incomeTotal:C}");

            decimal netIncome = incomeTotal - billTotal;

            WriteLine($"Income - Bills leaves you with {netIncome:C}");
            WriteLine($"This leaves you with {(netIncome / 30):C} per day in a 30 day month, if you do not intend to put any money into savings");


            //options for saving coming soon


































            //person.WriteToConsole();
        }
    }
}
