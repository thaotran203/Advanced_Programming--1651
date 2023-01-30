using System;

namespace StarRhombus
{
    internal class StarRhombus
    {
        public int size;
        public int Size { get; set; }
        public void PrintRow(int size, int starCount)
        {
            for (int i = 0; i < size - starCount; i++)
            {
                System.Console.Write(" ");
            }
            for (int i = 0; i < starCount; i++)
            {
                System.Console.Write("* ");
            }
            System.Console.WriteLine();
        }
    }
}
