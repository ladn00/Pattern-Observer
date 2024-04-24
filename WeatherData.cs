using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерн_Наблюдателя
{
    public class WeatherData : ISubject
    {
        public List<IObserver> observers { get; private set; }
        private float temperature;
        private float humidity;
        private float pressure;
        private string magneticStorm;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            for(int i = 0; i < observers.Count; i++)
            {
                IObserver observer = observers[i];
                observer.Update(temperature, humidity, pressure, magneticStorm);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void RegisterObject(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
                observers.RemoveAt(i);
        }

        public void SetMeasurements(float temp, float humidity, float pressure, string magneticStorm)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            this.magneticStorm = magneticStorm;
            MeasurementsChanged();
        }

        public float getTemperature()
        {
            return temperature;
        }

        public float getHumidity()
        {
            return humidity;
        }

        public float getPressure()
        {
            return pressure;
        }
        public string getMagneticStorm()
        {
            return magneticStorm;
        }
        
    }
}
