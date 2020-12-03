using SOLID.OpenClosePrinciple.ExampleOne.Good.Abstraction;

namespace SOLID.OpenClosePrinciple.ExampleOne.Good.Concrete
{
    public class Maccihato: GoodCoffee
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 5.25;
        }
    }
}
