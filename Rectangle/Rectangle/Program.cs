using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public class Rectangle
        {
            private int x;
            private int y;
            private int width;
            private int height;
            private int size;
            
            public Rectangle(int x, int y, int width, int height)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
            }

            public Rectangle(int x, int y, int size)
            {
                this.x = x;
                this.y = y;
                this.size = size;
            }

            public Rectangle(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public Rectangle(int size)
            {
                this.size = size;
            }

            public void MoveTo(int x, int y)
            {
                this.x = x;
                this.y = y;
                Console.WriteLine("Rectangle is at " + x + ", " + y + ".");
            }

            public bool IsSquare()
            {
                if (width == height)
                    return true;
                else return false;
            }

            public void Set(int x, int y, int width, int height)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
            }
        }
    }
}
