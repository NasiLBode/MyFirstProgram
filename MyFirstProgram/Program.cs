using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello out there!");
            Console.WriteLine("I will add two numbers for you.");
            Console.WriteLine("Enter one Number and press enter, then enter the second number and press enter.")
;
            //declare the two integer variables
            int n1, n2, sum;

            //string method
            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());

            //calculate the sum
            sum = n1 + n2;

            //print the message to the screen with the sum
            Console.WriteLine("The sum of those two numbers is: ");
            Console.WriteLine(sum);

            Console.ReadLine();

        }
    }
}
