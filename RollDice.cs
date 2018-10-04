using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDice
{
    class RollDice
    {
        public void Rolld4()
        {
            Random value = new Random();
            Console.WriteLine(value.Next(1, 4));
        }

        public void Rolld6()
        {
            Random value = new Random();
            Console.WriteLine(value.Next(1, 6));
        }

        public void Rolld8()
        {
            Random value = new Random();
            Console.WriteLine(value.Next(1, 8));
        }

        public void Rolld10()
        {
            Random value = new Random();
            Console.WriteLine(value.Next(1, 10));
        }

        public void Rolld12()
        {
            Random value = new Random();
            Console.WriteLine(value.Next(1, 12));
        }

        public void Rolld20()
        {
            Random value = new Random();
            Console.WriteLine(value.Next(1, 20));
        }
    }
}
