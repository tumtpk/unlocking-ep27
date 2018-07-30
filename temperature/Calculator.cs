using System;

namespace temperature {
    public class TempCalculator {

        public double ConvertFahrenheitToCelsius (double fahrenheit) {
            double celsius = (fahrenheit -32) * 5/9.0;
            return celsius;
        }
        
        public double ConvertKelvinToCelsius (double kelvin) {
            double celsius = kelvin - 273.15;
            return celsius;
        }

        public double ConvertCelsiusToFahrenheit (double celsius) {
            double fahrenheit = (1.8 * celsius) + 32;
            return fahrenheit;
        }
        
        public double ConvertKelvinToFahrenheit (double kelvin) {
            double fahrenheit = kelvin * 1.8 - 459.67;
            return fahrenheit;
        }
       
        public double ConvertFahrenheitToKelvin (double fahrenheit) {
            double kelvin = (fahrenheit + 459.67) / 1.8;
            return kelvin;
        }
        
        public double ConvertCelsiusToKelvin (double celsius) {
            double kelvin = celsius + 273.15;
            return kelvin;
        }

    }
}