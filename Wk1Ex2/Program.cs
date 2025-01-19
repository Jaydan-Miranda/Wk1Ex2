using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Displays the title Information Input
            Console.WriteLine("INFORMATION INPUT");

            // prints out the prompt to ask for the user's first name
            Console.WriteLine("What is your first name?");

            // declares a string variable to hold the user input for first name
            string fname = Console.ReadLine();

            // print out the prompt to ask for the user's last name
            Console.WriteLine("What is your last name?");

            // declare a string variable to hold the user input for last name
            string lname = Console.ReadLine();

            // print out the prompt to ask for the user's age
            Console.WriteLine("What is your age? ");

            // declare an int variable using a string to hold the user input for the age
            int age = Convert.ToInt32(Console.ReadLine()); // Note this code uses the "Convert.ToInt32" method to convert the string input to an integer

            // print out the prompt to ask for the color
            Console.WriteLine("What is your favorite color? ");

            // declare a string variable to hold the user input for the color
            string color = Console.ReadLine();

            //print out some comfirm message
            Console.WriteLine("Hello, " + fname + " " +lname + "! You are " + age + " years old and your favorite color is " + color + ".");

            //stop the screen for user to see the result
            Console.ReadLine();
        }
    }
}
