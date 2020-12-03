using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.InterfaceSegrationPrinciple.ExampleOne.Good.Abstraction;

namespace SOLID.InterfaceSegrationPrinciple.ExampleOne.Good.Concrete
{
    public class Hawk:IFlyingBird
    {
        public string Fly()
        {
            return "Şahin uçabilir.";
        }
    }
}
