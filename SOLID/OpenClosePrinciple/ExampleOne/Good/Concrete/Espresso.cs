using SOLID.OpenClosePrinciple.ExampleOne.Good.Abstraction;

namespace SOLID.OpenClosePrinciple.ExampleOne.Good.Concrete
{
    public class Espresso : GoodCoffee
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 6.75;
        }
    }
}
