using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime myValue = DateTime.Now;
            DateTime myValue = DateTime.Parse("4/19/1967");
            //Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
            //There are many versions of displaying date or time, including adding days or whatever
            Console.ReadLine();
        }
    }
}
