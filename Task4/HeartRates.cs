using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class HeartRates
    {
        //Initialize three string and four integers values
        private string _firstName;
        private string _lastName;
        private string _targetHeartRate;
        private int _birthYear;
        private int _currentYear;
        private int _age;
        private int _maximumHeartRate;

        //Default no input, constructor
        public HeartRates()
        {

        }

        //Constructor that takes four parameters
        public HeartRates(string fistName, string lastName, int birthYear, int currentYear)
        {
            //Set values
            FirstName = fistName;
            LastName = lastName;
            BirthYear = birthYear;
            CurrentYear = currentYear;

            //Start method for calculating age
            _age = age();

            //Start method for calculating maximum heart rate
            _maximumHeartRate = maximumHeartRate();

            //Start method for calculating target heart rate interval
            _targetHeartRate = calculateTargetHeartRateInterval();
        }

        //Property to read and modify firstname
        public string FirstName
        {
            get => this._firstName;
            set => this._firstName = value;
        }

        //Property to read and modify lastname
        public string LastName
        {
            get => this._lastName;
            set => this._lastName = value;
        }

        //Property to read and modify year of birth
        public int BirthYear
        {
            get => this._birthYear;
            set => this._birthYear = value;
        }

        //Property to read and modify current Year
        public int CurrentYear
        {
            get => this._currentYear;
            set => this._currentYear = value;
        }

        //Method to calculate age
        private int age()
        {
            //Calculate persons age
            int age =_currentYear - _birthYear;
            
            //return persons age
            return age;
        }

        //Method to calculate maximum heart rate
        private int maximumHeartRate()
        {
            //Calculate persons maximum heart rate
            int max = 220 - _age;

            //return persons maximum heart rate
            return max;
        }
        //Method to calculate minimum and maximum target heart rates and create a string
        private string calculateTargetHeartRateInterval()
        {
            //Calculate persons maximum target heart rate
            double max = _maximumHeartRate * 0.85;
            
            //Calculate persons minimum target heart rate
            double min = _maximumHeartRate * 0.50;

            //create a string
            string interval = $"{min} - {max}";

            //return persons target heart rate interval
            return interval;
        }
        
        //Display message to user
        public void ShowInformation()
        {
        Console.WriteLine("\nInformation:\n" +
                $"\tName: {_firstName} {_lastName}\n" +
                $"\tYear of birth: {_birthYear}\n" +
                $"\tAge: {_age}\n" +
                $"\tMaximum Heart Rate: {_maximumHeartRate}\n" +
                $"\tTarget interval: {_targetHeartRate}");
        }

    }
}
