using SOLID.LiskovSubstitutionPrinciple.ExampleOne.Good.Abstraction;

namespace SOLID.LiskovSubstitutionPrinciple.ExampleOne.Good.Concrete
{
    public class Square:Shape
    {
        public int Width { get; set; }

        public double SquareArea()
        {
            return Width * Width;
        }
    }
}
