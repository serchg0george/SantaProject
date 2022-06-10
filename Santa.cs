using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SantaProject.Interfaces;

namespace SantaProject
{
    public sealed class Santa
    {
        private Santa() 
        {
        
        }
        private ICommand command;
        private static Santa _santa;
        public static Santa GetSanta()
        {
            if (_santa == null)
            {
                _santa = new Santa();
            }
            return _santa;
        }

        public void INeedBike()
        {
            Console.WriteLine("Santa need bike");
            command = new BikeCommand();
            command.INeedProduct();
            
        }
        public void INeedDoll()
        {
            Console.WriteLine("Santa need doll");
            command = new DollCommand();
            command.INeedProduct();
        }

    }
}