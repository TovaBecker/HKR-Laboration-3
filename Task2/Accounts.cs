using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Accounts
    {
        //Creat Account object and assign it to myAccount 
        Account myAccount = new Account();

        //Accounts constructor
        public Accounts()
        {

        }

        public void OpenAccount()
        {
            //Present message to the user
            Console.WriteLine("\nYou want to open a new account");

            //Initialize and declare a value for successfully opening account
            bool sucess = false;

            while (sucess == false)
            {
                try
                {
                    //Present message to the user
                    Console.WriteLine("\nEnter the amount:");

                    //Assign value to myAccount Balance
                    myAccount.Balance = double.Parse(Console.ReadLine());

                    //Call myAccount's ShowMessage method with the followed parameter
                    String str = "\nYour account has been created\n";
                    myAccount.ShowMessage(str);

                    //call myAccount's ShowMessage method with another parameter
                    string dateNOW = Convert.ToString(DateTime.Now);
                    myAccount.ShowMessage("Your balance: " + myAccount.Balance + "\n\nToday: " + dateNOW);

                    sucess = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"You need to select a valid amount between 0 - {double.MaxValue}");
                }
            }
        }

        public void DepositMoney()
        {
            //Present message to the user
            Console.WriteLine("\nYou want to put some money in, enter the amount:");

            //call myAccount's ShowMessage method with another parameter
            string dateNOW = Convert.ToString(DateTime.Now);
            myAccount.ShowMessage("Your balance: " + myAccount.Balance + "\nToday: " + dateNOW);

            //prompt the account user to enter the amount
            Console.WriteLine("Enter the deposit amount: ");

            try
            {
                //Call myAccount's Deposit method
                myAccount.Balance = myAccount.Deposit(double.Parse(Console.ReadLine()));
            }
            catch (FormatException)
            {
                Console.WriteLine($"You need to select a valid deposit amount (positive number)\n");
            }

            //call myAccount's ShowMessage method with another parameter
            myAccount.ShowMessage("Your balance becomes with 5% bonus: " + myAccount.Balance);
            
        }
        public void WithdrawMoney()
        {
            //Present message to the user
            Console.WriteLine("\nYou want to withdraw some money, enter the amount:");

            //call myAccount's ShowMessage method with another parameter
            string dateNOW = Convert.ToString(DateTime.Now);
            myAccount.ShowMessage("Your balance: " + myAccount.Balance + "\nToday: " + dateNOW);

            //prompt the account user to enter the amount
            Console.WriteLine("Enter the withdraw amount: ");

            try
            {
                //Call myAccount's Deposit method
                myAccount.Balance = myAccount.Withdraw(double.Parse(Console.ReadLine()));
            }
            catch (FormatException)
            {
                Console.WriteLine($"You need to select a valid withdraw amount between 0 - {myAccount.Balance}\n");
            }

            //call myAccount's ShowMessage method with another parameter
            myAccount.ShowMessage("Your balance is now: " + myAccount.Balance);

        }
        public void CheckMoney()
        {
            //Present message to the user
            Console.WriteLine("\nYou want to check your balance");

            //call myAccount's ShowMessage method with another parameter
            string dateNOW = Convert.ToString(DateTime.Now);
            myAccount.ShowMessage("Your balance: " + myAccount.Balance + "\nToday: " + dateNOW);

        }
    }
}
