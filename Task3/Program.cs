using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print welcome messaege to user
            Console.WriteLine($"Welcome to the bicycle");

            //Print welcome messaege to user
            Console.WriteLine($"\n\tTest bicycles:");

            //Test no input value
            Bicycle bicycle1 = new Bicycle();
            Console.WriteLine($"\nFirst bicycle:\n\tID:{bicycle1.BicyckeId}\n\tmodel: {bicycle1.Model}\n\tSpeed: {bicycle1.Speed}");

            //Test no input value
            Bicycle bicycle2 = new Bicycle(12, "Crescent");
            Console.WriteLine($"\nSecond bicycle:\n\tID:{bicycle2.BicyckeId}\n\tmodel: {bicycle2.Model}\n\tSpeed: {bicycle2.Speed}");

            //Test no input value
            Bicycle bicycle3 = new Bicycle(60, "Monark");
            Console.WriteLine($"\nThird bicycle:\n\tID:{bicycle3.BicyckeId}\n\tmodel: {bicycle3.Model}\n\tSpeed: {bicycle3.Speed}");

            //Test input value from user
            //Declare and initialize two string and one integer value for input
            string inputModel;
            string menuSelection = "D";
            int inputSpeed = 0;

            //Initialize a ref varible for bike
            Bicycle mybicycle = bicycle1;

            //Print welcome messaege to user
            Console.WriteLine($"\n\tYour bicycle:");

            //Show menu untill user selects x or o
            while (menuSelection != "N")
            {
                //Show menue for user
                Console.WriteLine("\nPlease enter one of the following letters to enter the funktion:\n" +
                    "\tN to create your bicycle\n" +
                    "\tX to exit the program\n" +
                    "Press enter after your selection");

                //Get the selection from user
                menuSelection = Console.ReadLine().ToUpper();

                switch (menuSelection)
                {
                    case "N":
                        //Get model from user
                        Console.Write("Please enter the bicycle model and then press enter: ");
                        inputModel = Console.ReadLine();

                        //Declare and inisilise a book value for successfully create bike
                        bool success = false;

                        //Get speed from user
                        while (success == false)
                        {
                            //Ask speed from user
                            Console.Write("Please enter the bicycle speed and then press enter: ");
                            try
                            {
                                //Try to sett speed from user
                                inputSpeed = int.Parse(Console.ReadLine());

                                success = true;
                            }
                            catch (OverflowException)
                            {
                                //Present message to the user
                                Console.Write($"Not a valid speed, please enter a number between value 0 - 200\n");
                            }
                            catch (FormatException)
                            {
                                //Present message to the user
                                Console.Write($"Not a valid speed, please enter a number.\n");
                            }
                            catch
                            {
                                //Present message to the user
                                Console.Write($"Somthing whent wrong please contact support.\n");
                            }
                        }
                        //Create bike and show its information to user
                        Bicycle mynewbicycle = new Bicycle(inputSpeed, inputModel);
                        Console.WriteLine($"\nYour bicycle:\n\tID:{mynewbicycle.BicyckeId}\n\tmodel: {mynewbicycle.Model}\n\tSpeed: {mynewbicycle.Speed}");

                        //Ref mybike to the new bike
                        mybicycle = mynewbicycle;

                        break;
                    case "X":
                        //Present message to the user
                        Console.WriteLine($"Thank you for visiting us, hope to see you soon!");
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
            //Show menu untill user selects x or o
            while (menuSelection != "X")
            {
                //Show menue for user
                Console.WriteLine("\nPlease enter one of the following letters to enter the funktion:\n" +
                    "\tA to accelerate\n" +
                    "\tB to brake\n" +
                    "\tC to change the speed\n" +
                    "\tX to exit the program\n" +
                    "Press enter after your selection");

                //Get the selection from user
                menuSelection = Console.ReadLine().ToUpper();

                switch (menuSelection)
                {
                    case "C":
                        //Ask speed from user
                        Console.Write("Please enter the bicycle speed and then press enter: ");
                        try
                        {
                            //Try to set speed from user
                            inputSpeed = int.Parse(Console.ReadLine());

                            //set new speed
                            mybicycle.Speed = inputSpeed;

                        }
                        catch (OverflowException)
                        {
                            Console.Write($"Not a valid speed, please enter a number between value 0 - 200\n");
                        }
                        catch (FormatException)
                        {
                            Console.Write($"Not a valid speed, please enter a number.\n");
                        }
                        catch
                        {
                            Console.Write($"Somthing whent wrong please contact support.\n");
                        }
                        break;
                    case "A":
                        //Accelerate speed
                        mybicycle.Accelerate();
                        break;
                    case "B":
                        //Brake speed
                        mybicycle.Brake();
                        break;
                    case "X":
                        //Present message to the user
                        Console.WriteLine($"Thank you for visiting us, hope to see you soon!");
                        break;
                    default:
                        //Present message to the user
                        Console.WriteLine("Your selection is not at option in the menu.\n" +
                            "Please enter a selection from the menu.\n");
                        break;
                }
                //Show bike  information to user
                Console.WriteLine($"\tYour bicycle:\n\tID:{mybicycle.BicyckeId}\n\tmodel: {mybicycle.Model}\n\tSpeed: {mybicycle.Speed}");

            }
            //Close the program
            Environment.Exit(0);
        }
    }
}

