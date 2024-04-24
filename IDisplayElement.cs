using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Паттерн_Наблюдателя
{
    public interface IDisplayElement
    {
        void Display();
    }

    public class StatisticsDisplay : IDisplayElement, IObserver
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;
        private string magneticStorm;

        public void Display()
        {
            MessageBox.Show($"Статистика: ");
        }

        public void Update(float temp, float humidity, float pressure, string magneticStorm)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.magneticStorm = magneticStorm;
            Display();
        }

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObject(this);
        }
    }

    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;
        private string magneticStorm;

        public void Display()
        {
            MessageBox.Show("Прогноз погоды: \nБуря, метель, гроза, цунами. Одевайтесь теплее.");
        }

        public void Update(float temp, float humidity, float pressure, string magneticStorm)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.magneticStorm = magneticStorm;
            Display();
        }

    }

    public class ThirdPartyDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;
        private string magneticStorm;

        public ThirdPartyDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObject(this);
        }

        public void Display()
        {
            MessageBox.Show($"Др. информация: ");
        }

        public void Update(float temp, float humidity, float pressure, string magneticStorm)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.magneticStorm = magneticStorm;
            Display();
        }

    }

    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;
        private string magneticStorm; 

        public CurrentConditionDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObject(this);
        }
        public void Display()
        {
            MessageBox.Show($"Текущее состояние: \n{temperature} F градусов и {humidity} % влажности воздуха\nМагнитная буря: {magneticStorm}");
        }


        public void Update(float temp, float humidity, float pressure, string magneticStorm)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.magneticStorm = magneticStorm;
            Display();
        }
    }
}
