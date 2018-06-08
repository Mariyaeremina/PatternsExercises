using System.Collections.Generic;
using Patterns.Ex05.ExternalLibs;

namespace Patterns.Ex05.SubEx_02
{
    class DatabaseServerObservable : DatabaseSaver, IObservable
    {
        List<IObserver> observers;

        public DatabaseServerObservable()
        {
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update();
            }
        }
    }
}
