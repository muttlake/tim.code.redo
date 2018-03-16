

namespace Shape.Library
{
    public class Square: Rectangle
    {
        private int _length;
        public new int Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }

        public new int Width
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }

        public Square(int s): base(s, s)
        {
        }

        public new double Area()
        {
            return Length * Length;
        }
        public new double Perimeter()
        {
            return Length * 4;
        }
    }
}