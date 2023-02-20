using System;

namespace Demo_Singleton
{
    internal class KeyboardWindow
    {
        // field dùng chung
        private static KeyboardWindow instance;
        public static KeyboardWindow Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KeyboardWindow();
                }
                return instance;
            }
        }
        public double Height { get; set; }
        public double Width { get; set; }

        private KeyboardWindow()
        {

        }
        public override string ToString()
        {
            return $"Keyboard window has Height {Height}, Width {Width}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            KeyboardWindow window1 = KeyboardWindow.Instance;
            window1.Height = 5;
            window1.Width = 10;
            Console.WriteLine(window1);
            KeyboardWindow window2 = KeyboardWindow.Instance;
            window2.Height = 20;
            window2.Width = 30;
            Console.WriteLine(window2);
            Console.WriteLine(window1);

            Console.ReadLine();
        }
    }
}
