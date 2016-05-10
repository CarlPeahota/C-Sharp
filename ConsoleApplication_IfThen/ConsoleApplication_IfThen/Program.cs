using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_IfThen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THis is my giveaway...");
            Console.Write("Choose a door: 1, 2, or 3");

            string uservalue = Console.ReadLine();
            string message = "";

            if (uservalue == "1")
            {
                message = "You picked one";
            }
            else if (uservalue == "2")
            {
                message = "You picked two";
            }
            else if (uservalue == "3")
            {
                message = "You picked three";
            }
            else
            {
                message = "You picked nothing valid";

            }
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
