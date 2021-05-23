using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Bicycle
    {
        //Declare private value
        private int _bicyckeId;
        private int _speed;
        private string _model;

        //Declare private static value
        static int numberOfBiBicycke = 1000;

        //Default no input, constructor
        public Bicycle()
        {
            //Increes the value for the ID
            numberOfBiBicycke++;

            //Give the new bike its ID
            _bicyckeId = numberOfBiBicycke;

            //Set speed to zero
            _speed = 0;

            //Set model too Skeppshult
            _model = "Skeppshult";

        }
        //Constructor that takes two parameters
        public Bicycle(int speed, string model)
        {
            //Increes the value for the ID
            numberOfBiBicycke++;

            //Give the new bike its ID
            _bicyckeId = numberOfBiBicycke;

            //Set speed to 0
            Speed = speed;

            //Set model too Jaguar
            _model = model;
        }
        //Property to read ID
        public int BicyckeId
        {
            //Can only reed the model
            get => this._bicyckeId;
        }
        //Property to read and modify speed
        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value < 0)
                {
                    //Pressent error messge to the user
                    Console.WriteLine("\nThe bike can't have a speed lower than 0");
                }                    
                else if(200 < value)
                {
                    //Pressent error messge to the user
                    Console.WriteLine("\nThe bike can't go faster than 200");
                }
                else
                {
                    //Set speed as input value
                    this._speed = value;
                }
            }
        }
        //Property to read model
        public string Model
        {
            //Can only reed the model
            get => this._model;
        }

        public void Accelerate()
        {
            if (_speed <= 195)
            {
                //Increes the speed by 5
                _speed += 5;
            }
            else
            {
                //Set speed to 200
                _speed = 200;

                //Pressent error messge to the user
                Console.WriteLine("The bike can't go faster than 200");
            }
        }

        public void Brake()
        {
            if (5 <= _speed)
            {
                //Decrees the speed by 5
                _speed -= 5;
            }
            else if (0 < _speed && _speed <5)
            {
                //Set speed too zero
                _speed = 0;
                
            }
            else
            {
                //Set speed too zero
                _speed = 0;
                //Pressent error messge to the user
                Console.WriteLine("The bike can't brake more because it is standing still");
            }
        }
    }
}
