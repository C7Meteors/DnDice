using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDice
{
    class RollDice
    {
        public void Rolld(int dice)
        {
            Random value = new Random();
            Console.WriteLine(value.Next(1, dice));
        }
    }
}
