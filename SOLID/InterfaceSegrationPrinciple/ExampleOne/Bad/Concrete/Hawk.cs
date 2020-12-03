using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.InterfaceSegrationPrinciple.ExampleOne.Bad.Abstraction;

namespace SOLID.InterfaceSegrationPrinciple.ExampleOne.Bad.Concrete
{
    public class Hawk:IBird
    {
        public string Fly()
        {
            return "Şahin uçar..!";
        }

        public string Walk()
        {
            return "Şahin yürüyebilir..!";
        }
    }
}
