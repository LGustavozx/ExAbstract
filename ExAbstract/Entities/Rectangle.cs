using ExAbstract.Entities.Enums;

namespace ExAbstract.Entities
{
    class Rectangle : Shape
    {
        public double Widht { get; set; }
        public double Height { get; set; }

        public Rectangle (double width, double height, Color color) : base (color)
        {
            Widht = width;
            Height = height;
        }

        public override double Area()
        {
            return Widht * Height;
        }
    }
}
