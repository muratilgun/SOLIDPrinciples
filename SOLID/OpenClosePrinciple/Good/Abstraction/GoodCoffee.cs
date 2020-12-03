using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosePrinciple.Good.Abstraction
{
    public abstract class GoodCoffee
    {
        public abstract double GetTotalPrice(double amount);
    }
}
