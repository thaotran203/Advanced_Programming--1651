using System;

namespace HW_29._1._2023_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(10, 15);
            var rectangle = new Rectangle(20, 10);

            var result = rectangle.Contains(point);
            if (result == true)
            {
                Console.WriteLine("it’s inside the current rectangle");
            }
            Console.WriteLine("it’s not inside the current rectangle");


        }
    }
}
