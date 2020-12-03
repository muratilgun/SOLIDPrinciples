using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.InterfaceSegrationPrinciple.ExampleOne.Good.Abstraction;

namespace SOLID.InterfaceSegrationPrinciple.ExampleOne.Good.Concrete
{
    public class Penguin:IFlightlessBird
    {
        public string Walk()
        {
            return "Penguen yürüyebilir.";
        }
    }
}
