namespace HW_29._1._2023_Task2
{
    internal class Rectangle
    {
        private int _topLeft;
        private int _bottomRight;
        public Rectangle(int topLeft, int bottomRight)
        {
            _topLeft = topLeft;
            _bottomRight = bottomRight;
        }
        public bool Contains(Point point)
        {
            if (_bottomRight > point._x || _topLeft > point._y)
            {
                return false;
            }
            return true;
        }

    }
}
