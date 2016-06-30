using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string MyString = "The back-slashes will add \"quotes\" to the text";
            //string MyString = "Use the back-slash and n to \ninsert a new line.";
            //string MyString = "And if I want the back-slash to appear I would use an additional back slash such as c:\\";
            //string MyString = @"Or use the at-symbol instead of back-slash to show c:\";
            //string MyString = String.Format("{0} = {1}", "First","Second"); //Uses place-holders of 0 and 1
            //string MyString = String.Format("{0:C}",125.34); //0 is still the place-holder, C = currency
            //string MyString = String.Format("{0:N}", 1234567890); //0 is still the place-holder, N = large number format w/ 2 digit decimal
            //string MyString = String.Format("{0:P}", .125); //0 is still the place-holder, P converts to %
            //string MyString = String.Format("{0:(###) ###-####}", 1234567890); //0 is still the place-holder, # give customization, such as phone number

            //string MyString = "  For Those About To Rock  ";
            //MyString = MyString.Substring(6,5); //Give me everything starting from position 6 (plus 1), and the next 5
            //You can use other methods like: ToUpper, Replace, Remove, Trim

            //This can be inefficient for concatenating string; creates multiple buckets for EVERY concatenation
            /*
            string MyString = "";
            for (int i = 0; i < 100; i++)
            {
                MyString += "--" + i.ToString();
            }
            */

            //THis is more efficient; does not create multiple buckets
            StringBuilder MyString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                MyString.Append("--");
                MyString.Append(i);

            }

            Console.WriteLine(MyString);
            Console.ReadLine();
        }
    }
}
