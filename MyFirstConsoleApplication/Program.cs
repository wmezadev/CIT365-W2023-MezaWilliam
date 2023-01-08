using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main()
        {
            GetUserNameAndLocation();
            ChristmasCountdown();
            PauseApplicationPrompt();
            GlazerCalc.RunExample();
        }

        private static void GetUserNameAndLocation()
        {
            Console.WriteLine("Type name");
            string personName = Console.ReadLine();

            Console.WriteLine("Type location");
            string personLocation = Console.ReadLine();

            var person = new Person
            {
                Name = personName,
                Location = personLocation,
            };

            Console.WriteLine($"My name is {person.Name}, I am from {person.Location}.");
        }

        public static void PauseApplicationPrompt()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public static void ChristmasCountdown()
        {
            DateTime currentDate = DateTime.Now;
            string dateString = currentDate.ToString("MM/dd/yyyy");
            Console.WriteLine($"Current date is {dateString}");
            DateTime christmas = new DateTime(currentDate.Year, 12, 25);
            TimeSpan difference = christmas - currentDate;
            int daysUntilChristmas = difference.Days;
            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas.");
        }
    }
}
