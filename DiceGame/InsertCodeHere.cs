using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGame
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            Die Roll01 = new DiceGame.Die();
            Roll01.RollDie();

            Console.WriteLine("{0}", Roll01.GetValue());

            // The LAST line of code should be ABOVE this line
        }
    }
}
