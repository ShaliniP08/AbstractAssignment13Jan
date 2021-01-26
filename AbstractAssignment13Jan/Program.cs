using System;

namespace AbstractAssignment13Jan
{
    abstract class Quadilateral
    {
        protected int len;

        public Quadilateral()
        {

        }
        public Quadilateral(int l)
        {
            len = l;
        }

        public abstract int Area();

        public abstract int Perimeter();
    }

    class Square : Quadilateral
    {
        public Square()
        {

        }

        public Square(int l) : base(l)
        {
            
        }

        public override int Area()
        {
            int areaSq = len * len;
            Console.WriteLine($"Area of square : {areaSq}");
            return areaSq;
        }

        public override int Perimeter()
        {
            int perimeterSq = 4 * len;
            Console.WriteLine($"Perimeter of square : {perimeterSq}");
            return perimeterSq;
        }
    }

    class Rectangle : Quadilateral
    {
        int br;
        public bool isSquare { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(int l, int b) : base(l)
        {
            br = b;
        }
        public override int Area()
        {
            int areaRect = len * br;
            Console.WriteLine($"Area of rectangle : {areaRect}");
            return areaRect;
        }
        public override int Perimeter()
        {
            int perimeterRect = 2 * (len + br);
            Console.WriteLine($"Perimeter of rectangle : {perimeterRect}");
            return perimeterRect;
        }

        public bool IsSquare()
        {
            if(len==br)
            {
                Console.WriteLine("True : Rectangle is square");
                return true;
            }
            else
            {
                Console.WriteLine("False : Rectangle is not square");
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of square");
            int lengthSq = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Length of rectangle");
            int lengthRect = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth of rectangle");
            int breadth = Convert.ToInt32(Console.ReadLine());

            Square sq = new Square(lengthSq);
            Rectangle rect = new Rectangle(lengthRect, breadth);
            if (sq.Area() > rect.Area())
            {
                Console.WriteLine("Square's area is more than Rectangle's area");
            }
            else
            {
                Console.WriteLine("Square's area is less than Rectangle's area");
            }

            sq.Perimeter();
            rect.Perimeter();
            rect.IsSquare();

            Console.ReadLine();
        }
    }
}