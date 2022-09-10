using System;
using System.IO;

namespace WeatherData
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string[] weatherArray = File.ReadAllLines("weather.dat");
            string day;
            double maxDay;
            double minDay;
            double dayDiff;
            double? currentLowestTemp = null;
            string dayAnswer = "";
            const int dayCol = 2;
            const int maxTempCol = 6;
            const int minTempCol = 12;


            for (int i = 2; i < weatherArray.Length-1; i++)
            {
                
                day = weatherArray[i].Substring(dayCol, 2);
                maxDay = Convert.ToDouble(weatherArray[i].Substring(maxTempCol, 2));
                minDay = Convert.ToDouble(weatherArray[i].Substring(minTempCol, 2));
                dayDiff = maxDay - minDay;
                if (currentLowestTemp == null || dayDiff < currentLowestTemp)
                {
                    currentLowestTemp = dayDiff;
                    dayAnswer = day;
                }
            }

            Console.WriteLine("The day with the smallest temperature difference is: " + dayAnswer + " with a difference of " + currentLowestTemp);
            Console.ReadLine();
        }
    }
}
