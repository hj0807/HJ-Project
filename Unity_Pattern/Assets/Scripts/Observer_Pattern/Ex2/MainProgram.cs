using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern.ex2
{
    public class MainProgram : MonoBehaviour
    {
        void Main()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay display = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80f, 65f, 30.4f);
            weatherData.ChangeMeasurements();
        }
    }
}