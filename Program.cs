using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDice
{
    class Program
    {
        private static int dice;

        static void Main(string[] args)
        {
            Console.WriteLine("What type of dice would you like to roll?");
            Console.WriteLine("1. 4 sided");
            Console.WriteLine("2. 6 sided");
            Console.WriteLine("3. 8 sided");
            Console.WriteLine("4. 10 sided");
            Console.WriteLine("5. 12 sided");
            Console.WriteLine("6. 20 sided");
            Console.WriteLine();

            int dice;

            dice = int.Parse(Console.ReadLine());

            Console.Clear();

            if (dice == 1)
            {
                RollDice roll = new RollDice();
                roll.Rolld4();
            }

            if (dice == 2)
            {
                RollDice roll = new RollDice();
                roll.Rolld6();
            }

            if (dice == 3)
            {
                RollDice roll = new RollDice();
                roll.Rolld8();
            }

            if (dice == 4)
            {
                RollDice roll = new RollDice();
                roll.Rolld10();
            }

            if (dice == 5)
            {
                RollDice roll = new RollDice();
                roll.Rolld12();
            }

            if (dice == 6)
            {
                RollDice roll = new RollDice();
                roll.Rolld20();
            }

            if (dice > 6)
            {
                Console.WriteLine("I'm sorry, please choose an option between 1 and 6");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey();

        }

    }
}
