

namespace Shape.Library
{
    public abstract class Shape : IShape, IForm
    {
        public int Edges { get; }

        public Shape(int e)
        {
            Edges = e;
        }

        public abstract double Area();
        public abstract double Perimeter();
        public abstract double Volume();

    }
}