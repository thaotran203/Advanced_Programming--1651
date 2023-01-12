using System;

namespace Student_Programming
{
    internal class Student
    {
        private int age;
        private double gpa;
        private string name;

        //Properties
        public int Age
        {
            set { if (value > 0) age = value; }
            get { return age; }
        }

        public double Gpa
        {
            set { if (value > 0 || value <= 4) gpa = value; }
            get { return gpa; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"Student's name is " + name + " with age " + age + " has a GPA of " + gpa + ".");
        }

        public override string ToString()
        {
            return $"Student's name is " + name + " with age " + age + " has a GPA of " + gpa + ".";
        }
    }
}
