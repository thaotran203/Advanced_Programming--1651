using System;

namespace Dice_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of sides: ");
            int side = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the guessing number: ");
            int guessing = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your guesing number is {guessing} and the result of rolling the Dice is {Dice_Programming.Dice.Roll(side)}");
        }
    }
}
