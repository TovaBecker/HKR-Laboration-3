using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Sphere
    {
        //a. Private field of type integer
        private int _radius;

        //b.1 Empty constructor for class Sphere
        public Sphere()
        {
        }

        //b.2 Constructor that takes one int value for class Sphere
        public Sphere(int radius)
        {
            //Assign value to property
            Radius = radius;
        }
        
        //c.1 Property for modifying radius
        public int Radius
        {
            get =>this._radius;
            set => this._radius = radiusCheck(value);
        }

        private static int radiusCheck(int radius)
        {
            try
            {
                //c.2 Check radius value if unnder zero
                if (radius < 0)
                {
                    //c.3 Set radius to 0 and throw exceptions
                    radius = 0;
                    throw new ArgumentOutOfRangeException();
                }
 
            }
            catch (ArgumentOutOfRangeException)
            {
                //Display error message too user
                Console.WriteLine("\nRadien måste vara ett positivt heltal. ");
            }
            catch (Exception e)
            {
                //Display error message too user
                Console.WriteLine($"\nNågot gick fel \n {e.Message}");
            }
            return radius;
        }
        public float Volume()
        {
            //d. Calculate the volume of a sphere
            float volume = (float)(4.0 / 3 * Math.PI * _radius * _radius * _radius);

            return volume;
        }
    }
}
