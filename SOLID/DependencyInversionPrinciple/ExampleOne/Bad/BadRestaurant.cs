using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple.ExampleOne.Bad
{
    public class BadRestaurant
    {
        
        BadFish perch = new BadFish();
        BadPoultry duck = new BadPoultry();

        public string GenerateInstruction()
        {
            return perch.GetFishCookingInstructions() + " " + duck.GetPoultryCookingInstructions();
        }
    }
}
