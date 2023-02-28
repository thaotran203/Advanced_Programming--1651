using System;

namespace Coffee_Management_System_1651
{
    class OrderDetail
    {
        public MenuItem Item { get; set; }
        private int quantity;
        public int Quantity { get { return quantity; } set { quantity = value; } }

        public OrderDetail(MenuItem item, int quantity)
        {
            this.Item = item;
            Quantity = quantity;
        }

        public void OrderDrink()
        {
            Console.WriteLine();
        }
        public double GetTotalPrice()
        {
            return Item.Price * Quantity;
        }
    }
}
