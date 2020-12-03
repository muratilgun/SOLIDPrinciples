using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.OpenClosePrinciple.Good.Abstraction;

namespace SOLID.OpenClosePrinciple.Good.Concrete
{
    public class Latte: GoodCoffee
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 4.50;
        }
    }
}
