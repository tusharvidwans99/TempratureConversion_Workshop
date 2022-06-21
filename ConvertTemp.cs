using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempratureConversion
{
    public class ConvertTemp
    {
        /// <summary>
        /// This program will convert Fahrenheit temprature value to the celcius temprature vaulue.
        /// </summary>
        /// <param name="Fahrenheit"></param>
        public static void FahrenheitToCelcius()
        {
            Console.Write("Enter the Fahrenheit Value: ");
            int Fahrenheit = Convert.ToInt32(Console.ReadLine());
            int celcius;
            celcius = (Fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"{Fahrenheit} Degree Fahrenheit = {celcius} Degree Celsius");

        }


        /// <summary>
        /// This program will convert Celcius temprature value to the Fahrenheit temprature value.
        /// </summary>
        /// <param name="celcius"></param>
        public static void CelciusToFahrenheit()
        {
            Console.Write("Enter the Celcius Value: ");
            int celcius = Convert.ToInt32(Console.ReadLine());
            int Fahrenheit;
            Fahrenheit = (celcius * 9 / 5) + 32;

            Console.WriteLine($"{celcius} Degree Celcius = {Fahrenheit} Degree Fahrenheit");

        }

    }
}
