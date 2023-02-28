namespace Coffee_Management_System_1651
{
    internal class CoffeeFactory
    {
        public static MenuItem CreateMilkCoffe(double price, Size size)
        {
            return new MenuItem("Milk Coffee", price, size);
        }
        public static MenuItem CreateOreoLatte(double price, Size size)
        {
            return new MenuItem("Oreo Latte", price, size);
        }
        public static MenuItem CreatePeachTeaMania(double price, Size size)
        {
            return new MenuItem("Peach Tea Mania", price, size);
        }
        public static MenuItem CreateLycheeTea(double price, Size size)
        {
            return new MenuItem("Lychee Tea", price, size);
        }
        public static MenuItem CreateCaramelMacchiato(double price, Size size)
        {
            return new MenuItem("Caramel Macchiato", price, size);
        }
        public static MenuItem CreateAvocadoSmoothie(double price, Size size)
        {
            return new MenuItem("Avocado Smoothie", price, size);
        }
        public static MenuItem CreateBlueberryYogurt(double price, Size size)
        {
            return new MenuItem("Blueberry Yogurt", price, size);
        }
        public static MenuItem CreateNewItem(string name, double price, Size size)
        {
            return new MenuItem(name, price, size);

        }
    }
}
