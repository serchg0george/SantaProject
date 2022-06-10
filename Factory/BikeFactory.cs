using System;
using SantaProject.Interfaces;
using SantaProject.Model;

namespace SantaProject.Factories
{
    public class BikeFactory : Factory
    {
        public override IProduct GetProduct()
        {
            Console.WriteLine("Bike has been created");
            return new Bike();
        }
    }

}
