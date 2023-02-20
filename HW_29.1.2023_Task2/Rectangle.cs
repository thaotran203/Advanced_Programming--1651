namespace HW_29._1._2023_Task2
{
    internal class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public bool Contains(Point point)
        {
            bool isInHorizontal = this.TopLeft.X <= point.X && this.BottomRight.X >= point.X;
            bool isInVertical = this.TopLeft.Y <= point.Y && this.BottomRight.Y >= point.Y;
            bool isInRectangle = isInHorizontal && isInVertical;
            return isInRectangle;
        }

    }
}
