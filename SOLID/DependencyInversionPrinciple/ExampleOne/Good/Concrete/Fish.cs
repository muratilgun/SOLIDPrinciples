﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.DependencyInversionPrinciple.ExampleOne.Good.Abstraction;

namespace SOLID.DependencyInversionPrinciple.ExampleOne.Good.Concrete
{
    public class Fish : IProduct
    {
        public string GetCookingInstruction()
        {
            return "Balık Tarifleri";
        }
    }
}
