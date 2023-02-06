using System;

namespace HW_29._1._2023_Task3
{
    internal class Program
    {

        public static void DisplayMenu()
        {
            Print("==================================");
            Print("1. Add new student");
            Print("2. Print all student's information");
            Print("3. Find student by name");
            Print("4. Exit");
            Print("==================================");

        }
        public static void Print(string text)
        {
            System.Console.WriteLine(text);
        }

        static void Main(string[] args)
        {
            int choice = 1;
            Student student = new Student();
            Class cls = new Class();
            do
            {
                DisplayMenu();
                System.Console.Write("Please enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        cls.AddStudent();
                        break;
                    case 2:
                        cls.PrintStudentsInfo();
                        break;
                    case 3:
                        Console.Write("Enter student' name: ");
                        string studentName = Console.ReadLine();
                        cls.FindStudentByName(studentName);
                        break;
                    default:
                        Console.WriteLine("Exit the program!");
                        break;
                };
            }
            while (choice == 1 || choice == 2 || choice == 3);
        }
    }
}
