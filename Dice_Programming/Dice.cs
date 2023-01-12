using System;

namespace Dice_Programming
{
    internal class Dice
    {
        static int side;

        public static int Roll(int side)
        {
            Random rd = new Random();
            return rd.Next(1, side + 1);
        }
    }
}
