using System;

namespace WeatherStation {
    public class CurrentConditionsDisplay : IObserver, IDisplayElement {
        private float temperature;
        private float humidity;
        private ISubject weatherData;
        
        public CurrentConditionsDisplay(ISubject weatherData) {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }
        
        public void display() {
            string displayString = String.Format("Current Conditions: ${0}F degress and ${1}% humidity", temperature, humidity);
            Console.WriteLine(displayString);
        }

        public void update(float temp, float humidity, float pressure) {
            throw new NotImplementedException();
        }
    }
}