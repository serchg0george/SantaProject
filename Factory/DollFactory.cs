using System;
using SantaProject.Interfaces;
using SantaProject.Model;

namespace SantaProject.Factories
{
    public class DollFactory : Factory
    {
        public override IProduct GetProduct()
        {
            Console.WriteLine("Doll has been created");
            return new Doll();
        }
    }
}
