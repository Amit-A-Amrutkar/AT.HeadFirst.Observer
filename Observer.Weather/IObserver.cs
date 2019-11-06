using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Weather
{
    public interface IObserver
    {
        public void update(float temp , float humidity , float pressure);
    }
}
