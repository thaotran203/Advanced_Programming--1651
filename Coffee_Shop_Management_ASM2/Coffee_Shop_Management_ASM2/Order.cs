using System;

namespace Coffee_Shop_Management_ASM2
{
    class Order
    {
        private OrderDetail orderDetail;

        public DateTime OrderTime { get; set; }
        public double TotalPrice { get; set; }

        public Order(DateTime orderTime, double totalPrice)
        {
            this.OrderTime = orderTime;
            this.TotalPrice = totalPrice;
        }
    }
}