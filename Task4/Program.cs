using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize two string and two integer value for input
            string fistName;
            string lastName;
            int birthYear;
            int currentYear = 0;

            //Print welcome messaege to user
            Console.WriteLine($"Welcome to calculate your heart rates\n");

            //Get firstname from user
            Console.Write("Please enter your firstname and then press enter: ");
            fistName = Console.ReadLine().Trim();

            //Get Lastname from user
            Console.Write("Please enter your lastname and then press enter: ");
            lastName = Console.ReadLine().Trim();

            //Ask year of birth from user
            Console.Write("Please enter your year of birth and then press enter: ");
            //Get and check year of birth from user
            birthYear = checkYear();
                        
            //Declare and inisilise a bool value for a year after birth year
            bool success = false;

            //Check current year from user
            while (success == false)
            {
                //Ask current year from user
                Console.Write("Please enter current year and then press enter: ");

                //Get and check year of birth from user
                currentYear = checkYear();

                if (currentYear < birthYear)
                {
                    //Present message to the user
                    Console.Write($"Not a valid current year, please enter a year after year of birth {birthYear}\n");
                }
                else
                {
                    success = true;
                }

            }

            //Declare and initialize a HeartRates class whit 4 values
            HeartRates myHeartRates = new HeartRates(fistName, lastName, birthYear, currentYear);

            //Show information to user
            myHeartRates.ShowInformation();

            //Present message to the user
            Console.Write("\n\nPress enter to close program.\n");
            Console.ReadLine();

        }
        private static int checkYear()
        {
            //Declare and inisilise a interger for year value
            int year = 0;
            //Declare and inisilise a string for year value
            string inputYear;

            //Declare and inisilise a bool value for correct year
            bool success = false;

            //Check year from user
            while (success == false)
            {
                //Get year from user
                inputYear = Console.ReadLine();

                if (inputYear.Length < 4 && 4 > inputYear.Length)
                {
                    //Present message to the user
                    Console.Write($"Not a valid year, please enter a year with 4 digits(XXXX)\n");
                }
                else
                {
                    try
                    {
                        //Try to sett year from user
                        year = int.Parse(inputYear);
                        if (year < 1000 || 9999 < year)
                        {
                            //Present message to the user
                            Console.Write($"Not a valid year, please enter a year betwween 1000 - 9999\n");
                        }
                        else
                        {
                            success = true;
                        }
                    }
                    catch (OverflowException)
                    {
                        //Present message to the user
                        Console.Write($"Not a valid year, please enter a year between value {int.MinValue} - {int.MaxValue}\n");
                    }
                    catch (FormatException)
                    {
                        //Present message to the user
                        Console.Write($"Not a valid year, please enter a year.\n");
                    }
                    catch
                    {
                        //Present message to the user
                        Console.Write($"Somthing whent wrong please contact support.\n");
                    }
                }
               
            }

            //Reaturn correct year
            return year;
        }
    }
    
}
