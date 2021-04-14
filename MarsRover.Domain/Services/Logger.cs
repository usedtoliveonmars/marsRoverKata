using System;
using System.IO;

namespace MarsRover.Domain.Services
{
    public class Logger : ILogger
    {
        private readonly string fileLocation;

        public Logger(string recordedFileLocation)
        {
            try
            {
                File.WriteAllText(recordedFileLocation, "");
                fileLocation = recordedFileLocation;
            }
            catch (ArgumentException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The filepath you entered is NULL, we will continue without creating a logfile.\n");
                Console.ResetColor();
            }
        }

        public void Log(string message)
        {
            if (!string.IsNullOrEmpty(fileLocation))
            {
                File.AppendAllText(fileLocation, message + Environment.NewLine);
            }
        }
    }
}