using SOLID.OpenClosePrinciple.ExampleOne.Good.Abstraction;

namespace SOLID.OpenClosePrinciple.ExampleOne.Good.Concrete
{
    public class Latte: GoodCoffee
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 4.50;
        }
    }
}
