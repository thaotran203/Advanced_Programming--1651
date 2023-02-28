namespace Coffee_Management_System_1651
{
    public enum Size
    {
        Medium,
        Large
    }
    class MenuItem
    {
        private string name;
        private double price;
        private Size size;

        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }
        public Size Size { get { return size; } set { size = value; } }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
            Size = Size.Medium;
        }

        public MenuItem(string name, double price, Size size)
        {
            Name = name;
            Price = price;
            Size = size;
        }
    }
}
