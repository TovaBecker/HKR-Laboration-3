using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Program
    {
        //Main method is application's entry point
        static void Main(string[] args)
        {
            //Initialize user account
            Accounts myAccounts = new Accounts();

            //String values
            string userName;
            string menuSelection = "B";

            //Get user to give user name
            Console.WriteLine("Please enter your name and press enter: ");
            userName = Console.ReadLine();

            //Print welcome messaege to user
            Console.WriteLine($"\nWelcome {userName} to the Account Book! \nToday: {DateTime.Now}");


            //Show menu untill user selects x or o
            while (menuSelection != "O")
            {
                //Show menue for user
                Console.WriteLine("\nPlease enter one of the following letters to enter the function:\n" +
                    "\tO to open a account\n" +
                    "\tD to deposit money\n" +
                    "\tW to withdraw money\n" +
                    "\tC to check balance\n" +
                    "\tX to exit the program\n" +
                    "Press enter after your selection");

                //Get the selection from user
                menuSelection = Console.ReadLine().ToUpper();

                switch (menuSelection)
                {
                    case "O":
                        myAccounts.OpenAccount();
                        break;
                    case "D":
                        //Present message to the user
                        Console.WriteLine("You need to create a account before you can deposit money.");
                        break;
                    case "W":
                        //Present message to the user
                        Console.WriteLine("You need to create a account before you can withdraw money.");
                        break;
                    case "C":
                        //Present message to the user
                        Console.WriteLine("You need to create a account before you can check the balance.");
                        break;
                    case "X":
                        //Present message to the user
                        Console.WriteLine($"Thank you {userName} for visiting us, hope to see you soon!");
                        //Close the program
                        Environment.Exit(0);
                        break;
                    default:
                        //Present message to the user
                        Console.WriteLine("Your selection is not at option in the menu.\n" +
                            "Please enter a selection from the menu.\n");
                        break;
                }

            }
            //Show menu untill user selects x
            while (menuSelection != "X")
            {
                //Show menue for user
                Console.WriteLine("\nPlease enter one of the following letters to enter the function:\n" + 
                    "\tD to deposit money\n" +
                    "\tW to withdraw money\n" +
                    "\tC to check balance\n" +
                    "\tX to exit the program\n" +
                    "Press enter after your selection");

                //Get the selection from user
                menuSelection = Console.ReadLine().ToUpper();

                switch (menuSelection)
                {
                    case "D":
                        myAccounts.DepositMoney();
                        break;
                    case "W":
                        myAccounts.WithdrawMoney();
                        break;
                    case "C":
                        myAccounts.CheckMoney();
                        break;
                    case "X":
                        //Present message to the user
                        Console.WriteLine($"Thank you {userName} for visiting us, hope to see you soon!");
                        break;
                    default:
                        //Present message to the user
                        Console.WriteLine("Your selection is not at option in the menu.\n" +
                            "Please enter a selection from the menu.\n");
                        break;
                }
                
            }
        }
    }
}
