namespace HW_29._1._2023_Task3
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public Student()
        {

        }
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
        public void StudentInfo()
        {
            System.Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
        }

    }
}
