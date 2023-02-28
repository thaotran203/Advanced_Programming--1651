using System;

namespace Coffee_Management_System_1651
{
    class Bill : Order
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }

        public Bill(string customerName, string phoneNumber, DateTime orderTime, double totalPrice) : base(orderTime, totalPrice)
        {
            this.CustomerName = customerName;
            this.PhoneNumber = phoneNumber;
        }

        public void ViewOrder()
        {
            int i = 1;
            Console.WriteLine($"||    {i++}    |       {OrderTime}       |         {CustomerName}         |         {PhoneNumber}         |      {TotalPrice}      ||");
        }
    }
}
