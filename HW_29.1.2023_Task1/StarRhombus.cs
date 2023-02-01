namespace HW_29._1._2023_Task1
{
    class StarRhombus
    {
        private int size;
        public int Size { get; set; }
        public void PrintRow(int size, int stCount)
        {
            for (int i = 0; i < size - stCount; i++)
            {
                System.Console.Write(" ");
            }
            for (int i = 0; i < stCount; i++)
            {
                System.Console.Write("* ");
            }
            System.Console.WriteLine();
        }
    }
}
