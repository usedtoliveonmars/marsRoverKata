using MarsRover.Domain.Model;
using System;
using System.Text.RegularExpressions;

namespace MarsRover
{
    class Program
    {
        static void Main()
        {
            GetAppInfo(); //Run method to get app info

            //todo - set up logging
            SetLog(); //Setup Logging

            ControlTheRover(); //User controls the rover
        }

        private static void ControlTheRover()
        {
            Console.WriteLine("Welcome to The Mars Rover Kata!\n " +
                "Which way do you want the Rover to go?\n" +
                "F = Forward\n" +
                "B = Backward\n" +
                "L = Left\n" +
                "R = Right\n" +
                "Or Q = Quit");

            while (true)
            {
                //get user input
                string move = Console.ReadLine();

                //Change user input to lowercase
                String lowerCaseMove = move.ToLower();

                // check if input is a correct command
                var onlyAllowedCharacters = new Regex("^[f,b,l,r,q]*$");

                //while input contains invalid characters keep asking
                if (onlyAllowedCharacters.IsMatch(move) && (!String.IsNullOrEmpty(move)))
                {
                    Console.WriteLine("Your Rover moved " + move);
                    break;
                }

                PrintColorMessage(ConsoleColor.Red, "Please enter a valid command");
            }
        }

        //Print color message
        private static void PrintColorMessage(ConsoleColor color, string message)
        {
            //change test color
            Console.ForegroundColor = color;

            //Tell user its not a number
            Console.WriteLine(message);

            //reset test color
            Console.ResetColor();
        }

        private static void SetLog()
        {
        }

        private static void GetAppInfo()
        {
            string appName = "Mars Rover Kata";
            string appVersion = "0.1.0";
            string appAurthor = "Chris Cushman";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAurthor);

            Console.ResetColor();
        }
    }
}
