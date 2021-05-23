using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Account
    {
        //Declare an instance variable that holds the balance 
        private double balance;

        public Account()
        {
            Balance = 0;
        }

        //property to get and set the balance value
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value >= 0)

                    balance = value;
                else
                    balance = 0;
            }
        }

        //Write message to user
        public void ShowMessage(string str)
        {
            Console.WriteLine(str);
        }

        //Method for Deposit
        public double Deposit(double depositAmount)
        {
            //Check if deposit amount is a posetive number
            if (0 <= depositAmount)
            {
                try
                {
                    //you get a 5% bonus 
                    Balance += depositAmount * 1.05;
                }
                catch (OverflowException)
                {
                    //Display error message to user
                    Console.WriteLine("I am sorry but our bank book can not handel you amout of money pleas contakt our support for assistans.");
                }
            }
            else
            {
                //Display error message to user
                Console.WriteLine($"Sorry, you can not deporit a negetive amount");

            }

            return Balance;
        }

        //Metod for Withdraw
        public double Withdraw(double withdrawAmount)
        {
            //Check if withdrawAmount is a posetive number
            if (0 <= withdrawAmount)
            {
                if (0 <= (Balance - withdrawAmount))
                {
                    //Withdraw the asked amount from the account
                    Balance -= withdrawAmount;
                }
                else
                {
                    //Display error message to user
                    Console.WriteLine($"Sorry, you only have {Balance} in your accont so you can not withdraw {withdrawAmount}");
                }
            }
            else
            {
                //Display error message to user
                Console.WriteLine($"Sorry, you can not withdraw a negetive amount");

            }
            return Balance;
        }
    }
}
