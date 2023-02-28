namespace Coffee_Shop_Management_ASM2
{
    class MenuItem
    {
        private string name;
        private double price;
        enum Size
        {
            Medium,
            Large
        }

        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
