using SOLID.LiskovSubstitutionPrinciple.ExampleOne.Good.Abstraction;

namespace SOLID.LiskovSubstitutionPrinciple.ExampleOne.Good.Concrete
{
    public class Retangle: Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public double RetangleArea()
        {
            return Width * Height;
        }
    }
}
