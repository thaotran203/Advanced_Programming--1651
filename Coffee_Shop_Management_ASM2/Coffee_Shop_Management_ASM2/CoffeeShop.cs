using System;
using System.Collections.Generic;
using System.Linq;

namespace Coffee_Shop_Management_ASM2
{
    class CoffeeShop
    {
        private List<MenuItem> MenuItems;
        private List<OrderDetail> OrderDetails;
        private List<Bill> Bills;
        private List<Order> Orders;
        private List<Table> Tables;

        public CoffeeShop()
        {
            MenuItems = new List<MenuItem>();
            OrderDetails = new List<OrderDetail>();
            Bills = new List<Bill>();
            Orders = new List<Order>();
            Tables = new List<Table>();
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            MenuItems.Add(menuItem);
        }

        public void AddMenuItem()
        {
            Console.Write("Please enter name of the item: ");
            string name = Console.ReadLine();
            Console.Write("Please enter price of the item: ");
            double price = double.Parse(Console.ReadLine());
            MenuItems.Add(new MenuItem(name, price));
            Console.WriteLine("Added item successfully!");
        }

        public void PrintMenuCoffee()
        {
            Console.WriteLine(" =========================================================");
            Console.WriteLine("||            Name           ||           Price          ||");
            for (int i = 0; i < MenuItems.Count; i++)
            {
                Console.WriteLine($"|| {i + 1}.  {MenuItems[i].Name,-18}    ||          {MenuItems[i].Price} USD         ||");
            }
            Console.WriteLine(" =========================================================");
        }

        public void UpdatePrice()
        {
            Console.Write("Please choose the drink you want to update price: ");
            int drinkNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter a new price: ");
            MenuItems[drinkNumber - 1].Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Updated price successfully!");
        }

        public void DeleteItem()
        {
            Console.Write("Please choose the drink you want to delete: ");
            int drinkNumber = int.Parse(Console.ReadLine());
            MenuItems.Remove(MenuItems[drinkNumber - 1]);
            Console.WriteLine("Deleted item successfully!");
        }

        public void OrderDrink()
        {
            int drinkNumber = 1;
            int quantity;

            while (drinkNumber != 0)
            {
                Console.Write("Enter the number of drink you want to order: ");
                drinkNumber = int.Parse(Console.ReadLine());
                Console.Write("Enter the quantity: ");
                quantity = int.Parse(Console.ReadLine());

                if (OrderDetails.FirstOrDefault(o => o.Item.Name == MenuItems[drinkNumber - 1].Name) != null)
                {
                    var orderDetail = OrderDetails.FirstOrDefault(o => o.Item.Name == MenuItems[drinkNumber - 1].Name);
                    orderDetail.Quantity += quantity;
                }
                else
                {
                    OrderDetails.Add(new OrderDetail(MenuItems[drinkNumber - 1], quantity));
                    Console.WriteLine($"Added {MenuItems[(drinkNumber - 1)].Name} to cash");
                }
                Console.Write("Enter 1 to order more, 0 to cancel: ");
                drinkNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please choose the table: ");
            int tableID = int.Parse(Console.ReadLine());
            var table = Tables.FirstOrDefault(t => t.TableNumber == tableID);
            table.CheckinTable();
        }

        public void PrintBill()
        {
            Console.Write("Enter the table that the customer seat: ");
            int tableNumber = int.Parse(Console.ReadLine());
            var table = Tables.SingleOrDefault(t => t.TableNumber == tableNumber);
            int i = 1;
            double totalPrice = 0;

            Console.Write("Enter customer's name: ");
            string customerName = Console.ReadLine();
            Console.Write("Enter customer's phone number: ");
            string phoneNumber = Console.ReadLine();
            DateTime orderTime = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine("==================== PRINT BILL =======================");
            Console.WriteLine();
            foreach (OrderDetail detail in OrderDetails)
            {
                Console.WriteLine($"{i++}. {detail.Item.Name,-18} |       " + $"x{detail.Quantity}      |  {detail.Item.Price * detail.Quantity} USD");
                totalPrice = totalPrice + detail.Item.Price * detail.Quantity;
            }

            Console.WriteLine();
            Console.WriteLine($"The total price: {totalPrice} USD");
            Console.WriteLine("Thank you for coming!!! See ya later");

            Bill bill = new Bill(customerName, phoneNumber, orderTime, totalPrice);
            Bills.Add(bill);
            OrderDetails.Clear();
            table.CheckoutTable();
        }

        public void ViewAllOrder()
        {
            Console.WriteLine("======================================================================================================================================================");
            Console.WriteLine("||   No.   |           Date           |            Customer            |               Phone Number               |         Total Price         ||");
            foreach (Bill bill in Bills)
            {
                bill.ViewOrder();
            }
            Console.WriteLine("======================================================================================================================================================");
        }

        public void AddTable(Table table)
        {
            Tables.Add(table);
        }

        public void PrintAvailableTable()
        {
            Console.Write("Tables are available now: ");
            foreach (var table in Tables)
            {
                if (table.Status == Status.Available)
                {

                    Console.Write(table.TableNumber + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
