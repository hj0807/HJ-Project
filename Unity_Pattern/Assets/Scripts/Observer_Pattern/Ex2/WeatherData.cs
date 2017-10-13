using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern.ex2
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observerList;

        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observerList = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }

        public void NotifyObservers()
        {
            for(int i=0; i<observerList.Count; i++)
            {
                observerList[i].Update(temperature, humidity, pressure);
            }
        }

        public void ChangeMeasurements()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public float GetTemperature()
        {
            return temperature;
        }

        public float GetHumidity()
        {
            return humidity;
        }

        public float GetPressure()
        {
            return pressure;
        }
    }
}