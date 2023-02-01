using System;

namespace HW_29._1._2023_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StarRhombus starRhombus = new StarRhombus();
            Console.Write("Enter the size of the rhombus: ");
            starRhombus.Size = int.Parse(Console.ReadLine());
            for (int stCount = 1; stCount <= starRhombus.Size; stCount++)
            {
                starRhombus.PrintRow(starRhombus.Size, stCount);
            }

            for (int stCount = starRhombus.Size - 1; stCount >= 1; stCount--)
            {
                starRhombus.PrintRow(starRhombus.Size, stCount);
            }
        }
    }
}
