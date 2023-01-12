using System;

namespace Student_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information

            Student stu = new Student();
            Console.Write("Enter the name of that student: ");
            stu.Name = Console.ReadLine();
            Console.Write("Enter the age of that student: ");
            stu.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter the GPA of that student: ");
            stu.Gpa = double.Parse(Console.ReadLine());
            Console.WriteLine(stu);

        }
    }
}
