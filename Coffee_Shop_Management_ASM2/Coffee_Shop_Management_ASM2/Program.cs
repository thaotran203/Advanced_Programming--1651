using System;

namespace Coffee_Shop_Management_ASM2
{
    internal class Program
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("||       Please choose one of the option below!       ||");
            Console.WriteLine("|| 1. Display the menu                                ||");
            Console.WriteLine("|| 2. Add a new drink into the menu                   ||");
            Console.WriteLine("|| 3. Order drink for customer                        ||");
            Console.WriteLine("|| 4. Check available tables                          ||");
            Console.WriteLine("|| 5. View all orders                                 ||");
            Console.WriteLine("|| 6. Update drink price                              ||");
            Console.WriteLine("|| 7. Delete drink in menu                            ||");
            Console.WriteLine("|| 8. Checkout and Print bill                         ||");
            Console.WriteLine("|| 9. Exit the application                            ||");
            Console.WriteLine("========================================================");
        }
        static void Main(string[] args)
        {
            CoffeeShop Milan = new CoffeeShop();



            MenuItem item1 = new MenuItem("Milk Coffee", 6.5);

            MenuItem item2 = new MenuItem("Oreo Latte", 7.5);
            MenuItem item3 = new MenuItem("Peach Tea Mania", 6.7);
            MenuItem item4 = new MenuItem("Lychee Tea", 7.3);
            MenuItem item5 = new MenuItem("Caramel Macchiato", 6.8);
            MenuItem item6 = new MenuItem("Avocado Smoothie", 7.5);
            MenuItem item7 = new MenuItem("Blueberry Yogurt", 7.5);
            Milan.AddMenuItem(item1);
            Milan.AddMenuItem(item2);
            Milan.AddMenuItem(item3);
            Milan.AddMenuItem(item4);
            Milan.AddMenuItem(item5);
            Milan.AddMenuItem(item6);
            Milan.AddMenuItem(item7);

            Table table1 = new Table(1);
            Table table2 = new Table(2);
            Table table3 = new Table(3);
            Table table4 = new Table(4);
            Table table5 = new Table(5);
            Table table6 = new Table(6);
            Table table7 = new Table(7);
            Milan.AddTable(table1);
            Milan.AddTable(table2);
            Milan.AddTable(table3);
            Milan.AddTable(table4);
            Milan.AddTable(table5);
            Milan.AddTable(table6);
            Milan.AddTable(table7);


            int choice = 1;

            do
            {
                DisplayMenu();
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Milan.PrintMenuCoffee();
                        break;
                    case 2:
                        Milan.AddMenuItem();
                        break;
                    case 3:
                        Milan.OrderDrink();
                        break;
                    case 4:
                        Milan.PrintAvailableTable();
                        break;
                    case 5:
                        Milan.ViewAllOrder();
                        break;
                    case 6:
                        Milan.UpdatePrice();
                        break;
                    case 7:
                        Milan.DeleteItem();
                        break;
                    case 8:
                        Milan.PrintBill();
                        break;
                    default:
                        Console.Write("Invalid choice!");
                        break;
                };
            }
            while (0 < choice && choice <= 8);
        }
    }
}
