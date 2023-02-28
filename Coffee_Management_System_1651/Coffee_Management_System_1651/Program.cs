using System;

namespace Coffee_Management_System_1651
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
            CoffeeShop milan = new CoffeeShop();

            milan.AddMenuItem(CoffeeFactory.CreateMilkCoffe(6.5, Size.Medium));
            milan.AddMenuItem(CoffeeFactory.CreateMilkCoffe(7.2, Size.Large));
            milan.AddMenuItem(CoffeeFactory.CreateOreoLatte(6.8, Size.Medium));
            milan.AddMenuItem(CoffeeFactory.CreateOreoLatte(7.5, Size.Large));
            milan.AddMenuItem(CoffeeFactory.CreatePeachTeaMania(6.5, Size.Medium));
            milan.AddMenuItem(CoffeeFactory.CreatePeachTeaMania(7.2, Size.Large));
            milan.AddMenuItem(CoffeeFactory.CreateLycheeTea(6.5, Size.Medium));
            milan.AddMenuItem(CoffeeFactory.CreateLycheeTea(7.2, Size.Large));
            milan.AddMenuItem(CoffeeFactory.CreateCaramelMacchiato(6.8, Size.Medium));
            milan.AddMenuItem(CoffeeFactory.CreateCaramelMacchiato(7.5, Size.Large));


            Table table1 = new Table(1);
            Table table2 = new Table(2);
            Table table3 = new Table(3);
            Table table4 = new Table(4);
            Table table5 = new Table(5);
            Table table6 = new Table(6);
            Table table7 = new Table(7);
            milan.AddTable(table1);
            milan.AddTable(table2);
            milan.AddTable(table3);
            milan.AddTable(table4);
            milan.AddTable(table5);
            milan.AddTable(table6);
            milan.AddTable(table7);


            int choice = 1;

            do
            {
                DisplayMenu();
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        milan.PrintMenuCoffee();
                        break;
                    case 2:
                        milan.AddMenuItem();
                        break;
                    case 3:
                        milan.OrderDrink();
                        break;
                    case 4:
                        milan.PrintAvailableTable();
                        break;
                    case 5:
                        milan.ViewAllOrder();
                        break;
                    case 6:
                        milan.UpdatePrice();
                        break;
                    case 7:
                        milan.DeleteItem();
                        break;
                    case 8:
                        milan.PrintBill();
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
