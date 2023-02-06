namespace HW_2._2._2023_Task1
{
    class Student : Person
    {
        public string School { get; set; }
        public Student(string school)
        {
            School = school;
        }
        public Student(string name, string address) : base(name, address)
        {
        }
        public Student(string name, string address, string school) : base(name, address)
        {
            School = school;
        }
        public new void Print()
        {
            base.Print();
            System.Console.WriteLine($"School: {School}");
        }
    }
}
