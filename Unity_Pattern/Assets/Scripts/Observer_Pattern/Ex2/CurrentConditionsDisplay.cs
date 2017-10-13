using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern.ex2
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private ISubject weatherData;

        private float temperature;
        private float humidity;

        // 생성자에서 Subject를 Observer에 등록한다.
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;

            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;

            Display();
        }

        public void Display()
        {
            Debug.Log("온도 : " + temperature + ", 습도 : " + humidity);
        }
    }
}
