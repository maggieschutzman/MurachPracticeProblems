using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCsharp.LengthConverterIO {
    class Conversion {
        public string FromUnit { get; set; }
        public double FromValue { get; set; }
        public string ToUnit { get; set; }
        public double ToValue { get; set; }
        public double ConversionRatio { get; set; }
        public string NewConversion { get; set; }

        public double milesToKilometers(double FromValue) {
            double ToValue = FromValue * 1.6093;
            Console.WriteLine($"{FromValue} Miles = {ToValue} kilometers");
            return ToValue;
        }

        public double kilometeresToMiles(double FromValue) {
            double ToValue = FromValue * .6214; 
            Console.WriteLine($"{FromValue} Kilometers = {ToValue} Miles");
            return ToValue;
        }

        public double inchesToCentimeters(double FromUnit) {
            double ToUnit = FromUnit * 2.54;
            return ToUnit;
        }

        public double centimetersToInches(double FromUnit) {
            double ToUnit = FromUnit * .3937;
            return ToUnit;
        }



    }
}
