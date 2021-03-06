﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.DependencyInversionPrinciple.ExampleOne.Good.Abstraction;

namespace SOLID.DependencyInversionPrinciple.ExampleOne.Good.Concrete
{
    public class Restaurant
    {
        
        List<IProduct> products;

        public Restaurant ()
        {
            products = new List<IProduct>();
        }

        public string GenerateInstruction()
        {
            string instruction = string.Empty;

            foreach (var item in products)
            {
                instruction += " " + item.GetCookingInstruction();
            }

            return instruction;
        }

    }
}
