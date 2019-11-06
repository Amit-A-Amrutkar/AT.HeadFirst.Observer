using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Weather
{
    public interface ISubject
    {
        public void registerObserver(IObserver o);
        public void removeObserver(IObserver o);
        public void notifyObserver();
    }
}
