namespace HW_2._2._2023_Task1
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Person()
        {

        }
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public void Print()
        {
            System.Console.Write($"Name: {Name}, Address: {Address}, ");
        }
        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}";
        }
    }
}
