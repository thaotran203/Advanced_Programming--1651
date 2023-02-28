using System;

namespace Coffee_Shop_Management_ASM2
{
    public enum Status
    {
        Occupied,
        Available
    }
    class Table
    {
        public int TableNumber { get; set; }
        public Status Status { get; set; }
        public Table()
        {
            TableNumber = 1;
        }

        public Table(int tableNumber)
        {
            this.TableNumber = tableNumber;
            Status = Status.Available;
        }
        public void CheckTableStatus()
        {
            if (Status == Status.Available)
            {
                Console.WriteLine($"Table {TableNumber} is available");
            }
            else
            {
                Console.WriteLine($"Table {TableNumber} is occupied");
            }
        }
        public Status CheckoutTable()
        {
            return Status = Status.Available;
        }
        public Status CheckinTable()
        {
            return Status = Status.Occupied;
        }
    }
}
