using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarGame
{
    class Program
    {
        static void Main(string[] args)
        {
            double pennies = 0.00;
            double nickels = 0.0;
            double dimes = 0.0;
            double quarters = 0.0;
            double total = 0.0; ;

            //Tell the user object of the game
            Console.Write("Try to make $1 using coins.\n\n");

            //Prompt user for the amount of coins needed to make a dollar
            Console.Write("\nHow many pennies?");
            pennies = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nHow many nickels?");
            nickels = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nHow many dimes?");
            dimes = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nHow many quarters?");
            quarters = Convert.ToDouble(Console.ReadLine());

            //change value of total
            total = (pennies * .01) + (nickels * .05) + (dimes * .10) + (quarters * .25);

       
            //if statements to check whether total is equal to, greater than, or less than $1
            if (total == 1)
            {
                Console.WriteLine("\nCongratulations on winning the game!!!");
            }
            if (total > 1)
            {
                Console.WriteLine("\nYour total is {0}", total);
                Console.WriteLine("Your total is over $1.");
            }
            if (total < 1)
            {
                Console.WriteLine("Your total is {0}", total);
                Console.WriteLine("Your total is under $1.");
            }

            Console.ReadKey();
            

        }
    }
}
