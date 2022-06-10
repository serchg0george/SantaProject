﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaProject.Interfaces
{
    public interface ISubject
    {
        string product {get;set;}
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
