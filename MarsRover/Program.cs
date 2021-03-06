using MarsRover.Domain;
using MarsRover.Domain.Model;
using MarsRover.Domain.Services;
using System;

namespace MarsRover
{
    class Program
    {
        static void Main()
        {
            GetAppInfo(); //Run method to get app info

            ControlTheRover(); //User controls the rover
        }

        private static void ControlTheRover()
        {
            Console.WriteLine("Welcome to The Mars Rover Kata!\n" +
            "Please enter your logfile path. If you wish to continue without a logfile, please press enter to leave this blank");

            var path = Console.ReadLine();
            
            ILogger logger = new Logger(path);

            Console.WriteLine("Which way do you want the Rover to go?\n" +
                "F = Forward\n" +
                "B = Backward\n" +
                "L = Left\n" +
                "R = Right\n" +
                "Or Q = Quit");

            //create a new rover
            var rover = new Rover();

            while (true)
            {
                //get user input
                string move = Console.ReadLine();
                {
                    //switch based on forward, backward, left, right, quit
                    switch (move.ToUpper())
                    {
                        case "F":
                            rover.MoveForward();
                            Console.WriteLine($"Your Rover Moved Forward!\n {FormatLocation(rover)}");//New Location is " + rover.Location);
                            logger.Log("Example message"); // "Rover moved forward!
                            continue;
                        case "B":
                            rover.MoveBackward();
                            Console.WriteLine($"Your Rover Moved Backward!\n {FormatLocation(rover)}");
                            // "Rover moved backward!"
                            continue;
                        case "L":
                            rover.MoveLeft();
                            Console.WriteLine($"Your Rover Moved Left!\n {FormatLocation(rover)}");
                            continue;
                        case "R":
                            rover.MoveRight();
                            Console.WriteLine($"Your Rover Moved Right!\n {FormatLocation(rover)}");
                            continue;
                        default:
                            return;
                    }
                }
            }
        }

        private static string FormatLocation(Rover rover)
        {
            return $"Rover is at ({rover.Location.X}, {rover.Location.Y}) facing {rover.Orientation}";
        }

        private static void GetAppInfo()
        {
            string appName = "Mars Rover Kata";
            string appVersion = "1.0.0";
            string appAurthor = "Chris Cushman";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAurthor);

            Console.ResetColor();
        }
    }
}
