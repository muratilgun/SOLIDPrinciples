namespace SOLID.LiskovSubstitutionPrinciple.ExampleOne.Bad
{
    public class BadAreaCalculater
    {
        public static double CalculateArea(BadRectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }

        public static double CalculateArea(BadSquare square)
        {
            return square.Width * square.Height;
        }
    }
}
