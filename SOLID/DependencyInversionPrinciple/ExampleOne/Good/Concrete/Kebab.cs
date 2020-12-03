using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.DependencyInversionPrinciple.ExampleOne.Good.Abstraction;

namespace SOLID.DependencyInversionPrinciple.ExampleOne.Good.Concrete
{
    public class Kebab : IProduct
    {
        public string GetCookingInstruction()
        {
            return "Kebab tarifleri";
        }
    }
}
