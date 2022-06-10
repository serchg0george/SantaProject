using System;
using System.Collections.Generic;

namespace SantaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var santa = Santa.GetSanta();

            List<Gnome> gnomes = new List<Gnome>();
            for(int i = 0; i!=3; i++)
            {
                gnomes.Add(new Gnome());
            }

            var magickTable = MagickTable.GetMagickTable();
            foreach(var item in gnomes)
            {
                magickTable.Attach(item);
            }
            santa.INeedBike();
            santa.INeedDoll();
        }
    }
}
