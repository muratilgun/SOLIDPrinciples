using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.InterfaceSegrationPrinciple.ExampleOne.Bad.Abstraction;

namespace SOLID.InterfaceSegrationPrinciple.ExampleOne.Bad.Concrete
{
    public class Chicken:IBird
    {
        public string Fly()
        {
            return "Tavuk uçamaz..!";
        }

        public string Walk()
        {
            return "Tavuk yürüyebilir..!";
        }
    }
}
