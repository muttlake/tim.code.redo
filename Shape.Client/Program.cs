using System;
using Shape.Library;

namespace Shape.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayingWithRectangles();
        }

        static void PlayingWithRectangles()
        {
            var r = new Rectangle(5, 10);
            Console.WriteLine(r.Perimeter());
            Console.WriteLine(r.Area());
            Console.WriteLine(r.Volume());

            var sq = new Square(5);
            sq.Width = 10;
            sq.Width = 2;
            Console.WriteLine(sq.Perimeter());
            Console.WriteLine(sq.Area());
            Console.WriteLine(sq.Volume());

        }
    }
}
