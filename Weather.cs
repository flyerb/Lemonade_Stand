﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Weather
    {
        //variables
        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        

        //ctor
        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Rainy", "Cloudy" };
            FindCondition();
            FindTemp();

        }

        //methods

        public void FindCondition()
        {
            Random rnd = new Random();
            int index = rnd.Next(weatherConditions.Count);
            condition = weatherConditions[index];
            // Console.WriteLine(weatherConditions[index]);
        }

        public void FindTemp()
        {
            Random rnd = new Random();

            switch (condition)
            {
                case "Sunny":
                    temperature = rnd.Next(60, 100);
                    //Console.WriteLine("Sunny and " + temperature + " degrees");
                    break; 

                case "Rainy":
                    temperature = rnd.Next(40, 65);
                   // Console.WriteLine("Rainy and " + temperature + " degrees");
                    break;

                case "Cloudy":
                    temperature = rnd.Next(50, 95);
                   // Console.WriteLine("Cloudy and " + temperature + " degrees");
                    break;


            }
        }
       
    }
}
        //give a forecast and the actual day
        //loop through the days of of the week and assign a type of weather to each day.
        //
