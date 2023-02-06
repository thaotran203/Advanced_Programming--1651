using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_29._1._2023_Task3
{
    internal class Class
    {
        List<Student> stu = new List<Student>();
        public Class()
        {
            stu = new List<Student>();
        }
        public void PrintStudentsInfo()
        {
            foreach (Student student in stu)
            {
                student.StudentInfo();
            }
        }
        public void AddStudent()
        {
            Console.WriteLine("Please enter student's name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter student's age");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Please enter student's grade");
            double grade = double.Parse(System.Console.ReadLine());
            Student student = new Student(name, age, grade);
            stu.Add(student);
        }
        public void FindStudentByName(string stuName)
        {
            var student = stu.SingleOrDefault(s => s.Name == stuName);
            if (student != null)
            {
                student.StudentInfo();
            }

            //foreach(Student student in stu)
            //{
            //    if (student.Name == stuName)
            //    {
            //        student.StudentInfo();
            //    }
            //}
        }
        public void FindStudentsByName(string name)
        {
            var students = stu.Where(s => s.Name == name).ToList();
            students.ForEach(s => s.StudentInfo());
        }
    }
}
