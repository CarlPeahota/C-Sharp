using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game.");

            Console.Write("Whats your FIRST name?");
            string firstname = Console.ReadLine();

            Console.Write("Whats your LAST name?");
            string lastname = Console.ReadLine();

            Console.Write("Whats your CITY?");
            string cityname = Console.ReadLine();


            Console.Write("Results: ");
            string ReversedFirstName = ReverseString(firstname);
            string ReversedLastName = ReverseString(lastname);
            string ReversedCityName = ReverseString(cityname);

            DisplayResults(ReversedFirstName, ReversedLastName, ReversedCityName);

            Console.ReadLine();

        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return string.Concat(messageArray);

        }

        private static void DisplayResults(string ReversedFirstName, 
                                            string ReversedLastName,
                                            string ReversedCityName)
        {
            Console.Write(String.Format("{0} {1} {2}",
                ReversedFirstName,
                ReversedLastName,
                ReversedCityName));
        }

        private static void DisplayResults(string ReversedFirstName,
                                            string ReversedLastName,
                                            string ReversedCityName)
        {
            Console.Write(String.Format("{0} {1} {2}",
                ReversedFirstName,
                ReversedLastName,
                ReversedCityName));
        }
    }
}
