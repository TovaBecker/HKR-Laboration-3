using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //e.Test no input value
            Sphere sphere1 = new Sphere();
            Console.WriteLine($"Första globes radie:{sphere1.Radius}, volym: {sphere1.Volume()}");

            //e. Test input value -5
            Sphere sphere2 = new Sphere(-5);
            Console.WriteLine($"\nAndra globes radie:{sphere2.Radius}, volym: {sphere2.Volume()}");

            //e. Test input value 5
            Sphere sphere3 = new Sphere(5);
            Console.WriteLine($"\nTredje globes radie:{sphere3.Radius}, volym: {sphere3.Volume()}");

            //e. Test input value 10
            Sphere sphere4 = new Sphere(10);
            Console.WriteLine($"\nFjärde globes radie:{sphere4.Radius}, volym: {sphere4.Volume()}");


            //Declare and inisilise integer value
            int inputValue = 0;

            //Bool value to loop through untill user give a valid radius
            bool success = false;

            while (success == false)
            {
                //e. Test input value 10
                Console.WriteLine("\nSkriv en radie och tryck enter:");

                try
                {
                    //Get value from user
                    inputValue = int.Parse(Console.ReadLine());
                    success = true;
                }
                catch
                {
                    //Display error message to user
                    Console.WriteLine($"Du behöver ange en korrekt radie mellan värdena 0 - {int.MaxValue}");
                }

            }
            //Create a Shere whit the input value
            Sphere sphereInput = new Sphere(inputValue);
            //Displau radius and volume to the user
            Console.WriteLine($"\nFemte globes radie:{sphereInput.Radius}, volym: {sphereInput.Volume()}");
            
        }
    }
}
