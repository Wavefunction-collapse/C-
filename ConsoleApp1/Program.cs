using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = Math.PI;

            string value;
            // Get user input to determine decimals to display, ensure data is valid before proceeding 
            do
            {
                Console.WriteLine("Find Pi to the Nth Digit");
                Console.WriteLine("Enter value for how many decimals ");
                value = Console.ReadLine();

            } while (isDigitsOnly(value) == false);

            if (Convert.ToInt16(value) >= 15)
            {
                Console.WriteLine(Math.Round(Pi, 14));
                Console.ReadKey(true);

            }
            else
            {
                Console.WriteLine(Math.Round(Pi, Convert.ToInt16(value)));
                Console.ReadKey(true);

            }
        }
        // Check to see if value from user is numerical 
        public static bool isDigitsOnly(string value)
        {
            foreach (char c in value)
            {
                if (c < '0' || c > '9')
                    return false;

            }
            return true;

        }
    }
}
