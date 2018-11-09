using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDice
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What type of dice would you like to roll?");
            Console.WriteLine("Please enter a value between 4 and 20. Press enter when you have selected your dice.");
            Console.WriteLine();

            int diceRoll;

            diceRoll = int.Parse(Console.ReadLine());

            Console.Clear();

            if (diceRoll >= 4)
            {
                if (diceRoll <= 20)
                {
                    RollDice roll = new RollDice();
                    roll.Rolld(diceRoll);
                }
            }

            else
            {
                Console.WriteLine("Please enter a value between 4 and 20.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey();

        }

    }
}
