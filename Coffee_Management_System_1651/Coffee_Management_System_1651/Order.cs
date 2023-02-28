using System;

namespace Coffee_Management_System_1651
{
    class Order
    {
        public DateTime OrderTime { get; set; }
        public double TotalPrice { get; set; }

        public Order(DateTime orderTime, double totalPrice)
        {
            this.OrderTime = orderTime;
            this.TotalPrice = totalPrice;
        }
    }
}
