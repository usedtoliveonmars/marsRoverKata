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

            //create a new rover
            var rover = new Rover();

            //get user input
            string move = Console.ReadLine();

            //switch based on forward, backward, left, right, quit
            switch (move.ToUpper())
            {
                case "F":
                    rover.MoveForward();
                    Console.WriteLine($"Your Rover Moved Forward!\n {FormatLocation(rover)}");//New Location is " + rover.Location);
                    return;
                case "B":
                    Console.WriteLine("Your Rover Moved Forward!\n New Location is " + rover.Location);
                    return;
                case "L":
                    Console.WriteLine("Your Rover Moved Left!\n New Location is " + rover.Location);
                    return;
                case "R":
                    Console.WriteLine("Your Rover Moved Right!\n New Location is " + rover.Location);
                    return;
                default:
                    break;
            }
        }

        private static string FormatLocation(Rover rover)
        {
            return $"Rover is at ({rover.Location.X}, {rover.Location.Y}) facing {rover.Orientation}";
            // Rover is at (0, 1) facing North
        }

        //while (true)
        //{
        //    // check if input is a correct command
        //    var onlyAllowedCharacters = new Regex("^[F,B,L,R,Q]*$");

        //    //while input contains invalid characters keep asking
        //    if (onlyAllowedCharacters.IsMatch(upperCaseMove) && (!String.IsNullOrEmpty(upperCaseMove)))
        //    {
        //        MoveRover(upperCaseMove);
        //        return;
        //    }

        //    PrintColorMessage(ConsoleColor.Red, "Please enter a valid command");
        //}

        //Print color message

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
