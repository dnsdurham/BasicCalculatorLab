using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC WEATHER CALCULATOR ***");

            // declare some variables
            string input;
            int temp;
            int relHumdity;
            int dewPoint;


            // Ask the user for the temp
            Console.WriteLine("Enter a temp");
            input = Console.ReadLine();
            temp = int.Parse(input);

            // Ask them for rel humidity
            Console.WriteLine("Enter RH");
            input = Console.ReadLine();
            relHumdity = int.Parse(input);

            // calculate the dew point
            dewPoint = temp - 9 * (100 - relHumdity) / 25;

            // print the dew point
            Console.WriteLine("Dew point = " + dewPoint);

            // ask for the windspeed

            // calculate the wind chill

            // print the wind chill
        }
    }
}
