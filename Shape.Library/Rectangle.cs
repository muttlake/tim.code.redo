

namespace Shape.Library
{
    public class Rectangle : Shape
    {

        public int Length {get; set;}
        public int Width {get; set;}

        public Rectangle(): base(4)
        {

        }

        public Rectangle(int l, int w): base(4)
        {
            Length = l;
            Width = w;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override double Volume()
        {
            return 0;
        }

        public override double Perimeter()
        {
            return 2 * (Length + Width);
        }

    }
}