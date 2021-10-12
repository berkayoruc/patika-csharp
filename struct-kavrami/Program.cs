using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.longEdge = 4;
            rect.shortEdge = 3;
            Console.WriteLine(rect.Area());

            RectangleStruct rects;
            rects.longEdge = 5;
            rects.shortEdge = 3;
            Console.WriteLine(rects.Area());
        }
    }

    class Rectangle
    {
        public int shortEdge;
        public int longEdge;

        public Rectangle()
        {
            shortEdge = 1;
            longEdge = 2;
        }

        public long Area()
        {
            return this.shortEdge * this.longEdge;
        }
    }

    struct RectangleStruct
    {
        public int shortEdge;
        public int longEdge;

        public RectangleStruct(int x, int y)
        {
            longEdge = x;
            shortEdge = y;
        }

        public long Area()
        {
            return this.shortEdge * this.longEdge;
        }
    }
}
