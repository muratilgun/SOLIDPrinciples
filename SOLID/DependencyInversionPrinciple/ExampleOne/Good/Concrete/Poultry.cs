using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.DependencyInversionPrinciple.ExampleOne.Good.Abstraction;

namespace SOLID.DependencyInversionPrinciple.ExampleOne.Good.Concrete
{
    public class Poultry : IProduct
    {
        public string GetCookingInstruction()
        {
            return "Kümes hayvanları pişirme yöntemleri";
        }
    }
}
