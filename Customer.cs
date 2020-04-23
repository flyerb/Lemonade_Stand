using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
     class Customer
    {
        // variables

        public string name;
        private List<string> names;
        public Weather weather;
        public Recipe recipe;
        Random rnd = new Random();

        //ctor
        public Customer()
        {
           Weather weather = new Weather(rnd);
            Recipe recipe = new Recipe();
           MakeChoice(weather, recipe);
           names = new List<string>() { };
        }

        //methods
        public bool MakeChoice(Weather weather, Recipe recipe) 
        {
            Random rnd = new Random();

            if (weather.condition == "Sunny" || recipe.priceVariable == "cheap")
            {
                int newInt = rnd.Next(4, 10);
                if (newInt >= 5)
                    return true;

            }
            if (weather.condition == "Cloudy" || recipe.priceVariable == "marketValue")
            {
                int newInt = rnd.Next(4, 10);
                if (newInt >= 5)
                    return true;
            }
            if (weather.condition == "Rainy" || recipe.priceVariable == "tooHigh")
            {
                int newInt = rnd.Next(1, 10);
                if (newInt >= 5)
                    return true;
            }
                return false;


        }
    }
}
