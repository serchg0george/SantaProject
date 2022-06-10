using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SantaProject.Interfaces;
using SantaProject.Factories;

namespace SantaProject
{
    public class Gnome : IObserver
    {
        private Factory factory;

        public Gnome()
        {}

        public void Update(ISubject subject)
        {
            
            if(subject.product == "Doll")
            {
                factory = new DollFactory();
            }
            else if(subject.product == "Bike")
            {
                factory = new BikeFactory();
            }
            else
            {
                Console.WriteLine("Something went wrong :(");
                return;
            }

            factory.GetProduct();
        }
    }
}
