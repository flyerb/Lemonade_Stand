using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
     class Customer
    {
        public string name;
        private List<string> names;
        public Weather weather;
        public Recipe recipe;
        //ctor
        public Customer()
        {
           // MakeChoice(weather);
            names = new List<string>() { };
        }

        //methods
        public bool MakeChoice(Weather weather)
        {
            Random rnd = new Random();

            if (weather.condition == "Sunny") 
            {
                int newInt = rnd.Next(4, 10);
                if (newInt >= 5)
                    return true;

            }
            else if (weather.condition == "Cloudy") 
            {
                int newInt = rnd.Next(4, 10);
                if (newInt >= 5)
                    return true;
            }
            else if (weather.condition == "Rainy") 
            {
                int newInt = rnd.Next(1, 10);
                if (newInt >= 5)
                    return true;
            }
                return false;


        }
    }
}
