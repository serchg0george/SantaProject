using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SantaProject.Interfaces;

namespace SantaProject
{
    public class BikeCommand : ICommand
    {
        public void INeedProduct()
        {
            MagickTable.GetMagickTable().WriteOnMagickTable("Bike");
        }
    }
}
