using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SantaProject.Interfaces;

namespace SantaProject
{
    public sealed class MagickTable : ISubject
    {
        public string product{get; set;}
        private List<IObserver> _observers = new List<IObserver>();
        private MagickTable() { }
        private static MagickTable _magickTable;
        public static MagickTable GetMagickTable()
        {
            if (_magickTable == null)
            {
                _magickTable = new MagickTable();
            }
            return _magickTable;
        }
        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
        
        public void WriteOnMagickTable(string _product)
        {
            product = _product;
            Notify();
        }

    }
}
